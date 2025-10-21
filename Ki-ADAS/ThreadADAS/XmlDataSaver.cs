using Ki_ADAS.DB;
using System;
using System.IO;
using System.Text;
using System.Xml;

namespace Ki_ADAS.ThreadADAS
{
    public class XmlDataSaver
    {
        private readonly Result _result;
        private readonly Model _curModel;
        private readonly Thread_FRCam _frCam;
        private readonly string _cycleTime;

        public XmlDataSaver(Result result, Model curModel, Thread_FRCam frCam, string cycleTime)
        {
            _result = result;
            _curModel = curModel;
            _frCam = frCam;
            _cycleTime = cycleTime;
        }

        public void Save(string filePath)
        {
            using (XmlTextWriter textWriter = new XmlTextWriter(filePath, Encoding.UTF8))
            {
                textWriter.Formatting = Formatting.Indented;
                textWriter.WriteStartDocument();

                textWriter.WriteStartElement("STATION_SETTING");

                WriteStaticElements(textWriter);
                WriteAdasCalibrationProcess(textWriter);
                WritePevProcess(textWriter);

                textWriter.WriteEndElement(); // STATION_SETTING
                textWriter.WriteEndDocument();
            }
        }

        private void WriteStaticElements(XmlTextWriter textWriter)
        {
            textWriter.WriteStartElement("DataModel");
            textWriter.WriteAttributeString("version", "1.2.B");
            textWriter.WriteEndElement();

            textWriter.WriteStartElement("FileFormat");
            textWriter.WriteAttributeString("version", "1.2.B");
            textWriter.WriteEndElement();

            textWriter.WriteElementString("MainPart_ID", _result.AcceptNo);
            textWriter.WriteElementString("Site", "UGB");
            textWriter.WriteElementString("TopStartCyclePart", "true");
            textWriter.WriteElementString("TopPart", "true");
        }

        private void WriteAdasCalibrationProcess(XmlTextWriter textWriter)
        {
            textWriter.WriteStartElement("ADASCalibrationProcessType");

            bool allSensorsOk = (_curModel.FC_IsTest ? _result.FC_IsOk : true) &&
                                (_curModel.F_IsTest ? _result.FR_IsOk : true) &&
                                (_curModel.R_IsTest ? _result.RR_IsOk : true);

            textWriter.WriteElementString("VerdictOK", allSensorsOk.ToString().ToLower());
            textWriter.WriteElementString("BenchNumber", "2");
            textWriter.WriteElementString("CycleTime", _cycleTime);

            WriteSensorToolTypesList(textWriter);

            textWriter.WriteEndElement(); // ADASCalibrationProcessType
        }

        private void WriteSensorToolTypesList(XmlTextWriter textWriter)
        {
            textWriter.WriteStartElement("ADASSensorToolTypesList");

            WriteFrontCamera(textWriter);
            WriteFrontRadarRight(textWriter);
            WriteFrontRadarLeft(textWriter);
            WriteRearRadarRight(textWriter);
            WriteRearRadarLeft(textWriter);

            textWriter.WriteEndElement(); // ADASSensorToolTypesList
        }

        private void WriteFrontCamera(XmlTextWriter textWriter)
        {
            WriteSensorToolType(textWriter, "CAM", "FRC", "FRONT CAMERA", "CENTRAL", "FRONT",
                _curModel.FC_IsTest, _result.FC_IsOk,
                () =>
                {
                    textWriter.WriteElementString("MeasureCount", "1");
                    textWriter.WriteElementString("FinalAngleX", _frCam.FinalAngleX.ToString("F6"));
                    textWriter.WriteElementString("FinalAngleY", _frCam.FinalAngleY.ToString("F6"));
                    textWriter.WriteElementString("FinalAngleZ", _frCam.FinalAngleZ.ToString("F6"));
                    textWriter.WriteElementString("ShapeType", "2");
                    textWriter.WriteElementString("CmdPositionTargetWheelAxis", (_curModel.FC_Distance ?? 0).ToString("F6"));
                    textWriter.WriteElementString("CmdPositionTargetSensor", null);
                    textWriter.WriteElementString("CmdPositionTargetCarAxis", (_curModel.FC_AlignmentAxeOffset ?? 0).ToString("F6"));
                    textWriter.WriteElementString("CmdPositionTargetHeight", (_curModel.FC_Height ?? 0).ToString("F6"));
                    textWriter.WriteElementString("CmdPositionTargetAngle", null);
                    textWriter.WriteElementString("CmdTargetShapeHeight", (_curModel.FC_Htu ?? 0).ToString("F6"));
                    textWriter.WriteElementString("CmdTargetEntrax", (_curModel.FC_InterDistance ?? 0).ToString("F6"));
                    textWriter.WriteElementString("FinalCycleTime", _cycleTime);
                });
        }

        private void WriteFrontRadarRight(XmlTextWriter textWriter)
        {
            WriteSensorToolType(textWriter, "RAD", "FRR", "FRONT RADAR RIGHT", "RIGHT", "FRONT",
                _curModel.F_IsTest, _result.FR_IsOk,
                () =>
                {
                    textWriter.WriteElementString("MeasureCount", "1");
                    textWriter.WriteElementString("FinalAngleX", (_curModel.FR_X ?? 0).ToString("F6"));
                    textWriter.WriteElementString("FinalAngleY", (_curModel.FR_Y ?? 0).ToString("F6"));
                    textWriter.WriteElementString("FinalAngleZ", (_curModel.FR_Z ?? 0).ToString("F6"));
                    WriteNullRadarElements(textWriter);
                    textWriter.WriteElementString("FinalCycleTime", _cycleTime);
                });
        }

        private void WriteFrontRadarLeft(XmlTextWriter textWriter)
        {
            WriteSensorToolType(textWriter, "RAD", "FRR", "FRONT RADAR LEFT", "LEFT", "FRONT",
                _curModel.F_IsTest, _result.FR_IsOk,
                () =>
                {
                    textWriter.WriteElementString("MeasureCount", "1");
                    textWriter.WriteElementString("FinalAngleX", (_curModel.FL_X ?? 0).ToString("F6"));
                    textWriter.WriteElementString("FinalAngleY", (_curModel.FL_Y ?? 0).ToString("F6"));
                    textWriter.WriteElementString("FinalAngleZ", (_curModel.FL_Z ?? 0).ToString("F6"));
                    WriteNullRadarElements(textWriter);
                    textWriter.WriteElementString("FinalCycleTime", _cycleTime);
                });
        }

        private void WriteRearRadarRight(XmlTextWriter textWriter)
        {
            WriteSensorToolType(textWriter, "RAD", "RSR", "REAR RADAR RIGHT", "RIGHT", "REAR",
                _curModel.R_IsTest, _result.RR_IsOk,
                () =>
                {
                    textWriter.WriteElementString("MeasureCount", "1");
                    textWriter.WriteElementString("FinalAngleX", (_curModel.RR_X ?? 0).ToString("F6"));
                    textWriter.WriteElementString("FinalAngleY", (_curModel.RR_Y ?? 0).ToString("F6"));
                    textWriter.WriteElementString("FinalAngleZ", (_curModel.RR_Z ?? 0).ToString("F6"));
                    WriteNullRadarElements(textWriter);
                    textWriter.WriteElementString("FinalCycleTime", _cycleTime);
                });
        }

        private void WriteRearRadarLeft(XmlTextWriter textWriter)
        {
            WriteSensorToolType(textWriter, "RAD", "RSL", "REAR RADAR LEFT", "LEFT", "REAR",
                _curModel.R_IsTest, _result.RR_IsOk,
                () =>
                {
                    textWriter.WriteElementString("MeasureCount", "1");
                    textWriter.WriteElementString("FinalAngleX", (_curModel.RL_X ?? 0).ToString("F6"));
                    textWriter.WriteElementString("FinalAngleY", (_curModel.RL_Y ?? 0).ToString("F6"));
                    textWriter.WriteElementString("FinalAngleZ", (_curModel.RL_Z ?? 0).ToString("F6"));
                    WriteNullRadarElements(textWriter);
                    textWriter.WriteElementString("FinalCycleTime", _cycleTime);
                });
        }

        private void WriteSensorToolType(XmlTextWriter textWriter, string sensorType, string name, string description,
            string lateralPosition, string longitudinalPosition, bool isPresent, bool verdictOk, Action writeData)
        {
            textWriter.WriteStartElement("ADASSensorToolType");
            textWriter.WriteAttributeString("ADASSensorType", sensorType);
            textWriter.WriteAttributeString("Name", name);
            textWriter.WriteAttributeString("Description", description);
            textWriter.WriteAttributeString("LateralPositionType", lateralPosition);
            textWriter.WriteAttributeString("LongitudinalPositionType", longitudinalPosition);
            textWriter.WriteElementString("VerdictOK", isPresent ? verdictOk.ToString().ToLower() : "false");
            textWriter.WriteElementString("IsPresent", isPresent.ToString().ToLower());
            textWriter.WriteElementString("FrictionResult", null);
            textWriter.WriteElementString("FinalFrictionTorque", null);

            if (isPresent)
            {
                writeData();
            }
            else
            {
                WriteNullSensorElements(textWriter);
            }

            textWriter.WriteEndElement(); // ADASSensorToolType
        }

        private void WriteNullSensorElements(XmlTextWriter textWriter)
        {
            textWriter.WriteElementString("MeasureCount", null);
            textWriter.WriteElementString("FinalAngleX", null);
            textWriter.WriteElementString("FinalAngleY", null);
            textWriter.WriteElementString("FinalAngleZ", null);
            textWriter.WriteElementString("ShapeType", null);
            textWriter.WriteElementString("CmdPositionTargetWheelAxis", null);
            textWriter.WriteElementString("CmdPositionTargetSensor", null);
            textWriter.WriteElementString("CmdPositionTargetCarAxis", null);
            textWriter.WriteElementString("CmdPositionTargetHeight", null);
            textWriter.WriteElementString("CmdPositionTargetAngle", null);
            textWriter.WriteElementString("CmdTargetShapeHeight", null);
            textWriter.WriteElementString("CmdTargetEntrax", null);
            textWriter.WriteElementString("FinalCycleTime", null);
        }

        private void WriteNullRadarElements(XmlTextWriter textWriter)
        {
            textWriter.WriteElementString("ShapeType", null);
            textWriter.WriteElementString("CmdPositionTargetWheelAxis", null);
            textWriter.WriteElementString("CmdPositionTargetSensor", null);
            textWriter.WriteElementString("CmdPositionTargetCarAxis", null);
            textWriter.WriteElementString("CmdPositionTargetHeight", null);
            textWriter.WriteElementString("CmdPositionTargetAngle", null);
            textWriter.WriteElementString("CmdTargetShapeHeight", null);
            textWriter.WriteElementString("CmdTargetEntrax", null);
        }

        private void WritePevProcess(XmlTextWriter textWriter)
        {
            textWriter.WriteStartElement("PEVProcessType");
            textWriter.WriteElementString("VerdictOK", "true");
            textWriter.WriteEndElement(); // PEVProcessType
        }
    }
}
