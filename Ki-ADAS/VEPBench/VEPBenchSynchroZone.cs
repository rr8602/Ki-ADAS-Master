using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ki_ADAS.VEPBench
{
    public class VEPBenchSynchroZone : IVEPBenchZone
    {
        private static VEPBenchSynchroZone _instance;
        private static readonly object _lock = new object();

        public const int SYNCHRO_SIZE_PART1 = 123;
        public const int SYNCHRO_SIZE_PART2 = 67;
        public const int DEFAULT_SYNCHRO_SIZE = SYNCHRO_SIZE_PART1 + SYNCHRO_SIZE_PART2;

        // 디바이스 타입 인덱스
        public const int DEVICE_TYPE_FRONT_CAMERA_INDEX = 3;
        public const int DEVICE_TYPE_REAR_RIGHT_RADAR_INDEX = 51;
        public const int DEVICE_TYPE_REAR_LEFT_RADAR_INDEX = 53;
        public const int DEVICE_TYPE_FRONT_RIGHT_RADAR_INDEX = 55;
        public const int DEVICE_TYPE_FRONT_LEFT_RADAR_INDEX = 57;

        // 동기화 명령 인덱스
        public const int SYNC_COMMAND_FRONT_CAMERA_INDEX = 4;
        public const int SYNC_COMMAND_REAR_RIGHT_RADAR_INDEX = 52;
        public const int SYNC_COMMAND_REAR_LEFT_RADAR_INDEX = 54;
        public const int SYNC_COMMAND_FRONT_RIGHT_RADAR_INDEX = 56;
        public const int SYNC_COMMAND_FRONT_LEFT_RADAR_INDEX = 58;

        // 각도값 인덱스 상수
        public const int FRONT_CAMERA_ANGLE1_INDEX = 110; // Roll
        public const int FRONT_CAMERA_ANGLE2_INDEX = 111; // Azimuth
        public const int FRONT_CAMERA_ANGLE3_INDEX = 112; // Elevation
        public const int REAR_RIGHT_RADAR_ANGLE_INDEX = 115;
        public const int REAR_LEFT_RADAR_ANGLE_INDEX = 116;
        public const int FRONT_RIGHT_RADAR_ANGLE_INDEX = 117;
        public const int FRONT_LEFT_RADAR_ANGLE_INDEX = 118;

        // Front Camera Send Info 상수
        public const int FRONT_CAMERA_DISTANCE_INDEX = 15;
        public const int FRONT_CAMERA_HEIGHT_INDEX = 16;
        public const int FRONT_CAMERA_INTERDISTANCE_INDEX = 17;
        public const int FRONT_CAMERA_HTU_INDEX = 29;
        public const int FRONT_CAMERA_HTL_INDEX = 30;
        public const int FRONT_CAMERA_TS_INDEX = 31;
        public const int FRONT_CAMERA_ALLIGNMENTAXEOFFSET_INDEX = 32;
        public const int FRONT_CAMERA_VV_INDEX = 33;
        public const int FRONT_CAMERA_STCT_INDEX = 34;

        // Rear Radar Send Info 상수
        public const int REAR_RADAR_LH_XPOSITION_INDEX = 67;
        public const int REAR_RADAR_LH_YPOSITION_INDEX = 68;
        public const int REAR_RADAR_LH_ZPOSITION_INDEX = 69;
        public const int REAR_RADAR_LH_ANGLE_INDEX = 70;
        public const int REAR_RADAR_RH_XPOSITION_INDEX = 71;
        public const int REAR_RADAR_RH_YPOSITION_INDEX = 72;
        public const int REAR_RADAR_RH_ZPOSITION_INDEX = 73;
        public const int REAR_RADAR_RH_ANGLE_INDEX = 74;

        // Front Radar Send Info 상수
        public const int FRONT_RADAR_LH_XPOSITION_INDEX = 95;
        public const int FRONT_RADAR_LH_YPOSITION_INDEX = 96;
        public const int FRONT_RADAR_LH_ZPOSITION_INDEX = 97;
        public const int FRONT_RADAR_LH_ANGLE_INDEX = 98;
        public const int FRONT_RADAR_RH_XPOSITION_INDEX = 99;
        public const int FRONT_RADAR_RH_YPOSITION_INDEX = 100;
        public const int FRONT_RADAR_RH_ZPOSITION_INDEX = 101;
        public const int FRONT_RADAR_RH_ANGLE_INDEX = 102;

        // Try / Retry 여부 인덱스 상수
        public const int TRY_FRONT_CAMERA_INDEX = 89;
        public const int TRY_REAR_RIGHT_RADAR_INDEX = 83;
        public const int TRY_REAR_LEFT_RADAR_INDEX = 82;

        public static VEPBenchSynchroZone Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                            _instance = new VEPBenchSynchroZone();
                    }
                }
                return _instance;
            }
        }

        private int[] _values;

        public int Size => _values.Length;

        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= _values.Length)
                    throw new IndexOutOfRangeException("Index out of range for VEPBenchSynchro values.");

                return _values[index];
            }
            set
            {
                if (index < 0 || index >= _values.Length)
                    throw new IndexOutOfRangeException("Index out of range for VEPBenchSynchro values.");

                _values[index] = value;
            }
        }

        public int FrontCameraAngle1
        {
            get => _values.Length > FRONT_CAMERA_ANGLE1_INDEX ? _values[FRONT_CAMERA_ANGLE1_INDEX] / 100 : 0;
            set => _values[FRONT_CAMERA_ANGLE1_INDEX] = value * 100;
        }

        public int FrontCameraAngle2
        {
            get => _values.Length > FRONT_CAMERA_ANGLE2_INDEX ? _values[FRONT_CAMERA_ANGLE2_INDEX] / 100 : 0;
            set => _values[FRONT_CAMERA_ANGLE2_INDEX] = value * 100;
        }

        public int FrontCameraAngle3
        {
            get => _values.Length > FRONT_CAMERA_ANGLE3_INDEX ? _values[FRONT_CAMERA_ANGLE3_INDEX] / 100 : 0;
            set => _values[FRONT_CAMERA_ANGLE3_INDEX] = value * 100;
        }

        public int RearRightRadarAngle
        {
            get => _values.Length > REAR_RIGHT_RADAR_ANGLE_INDEX ? _values[REAR_RIGHT_RADAR_ANGLE_INDEX] / 100 : 0;
            set => _values[REAR_RIGHT_RADAR_ANGLE_INDEX] = value * 100;
        }

        public int RearLeftRadarAngle
        {
            get => _values.Length > REAR_LEFT_RADAR_ANGLE_INDEX ? _values[REAR_LEFT_RADAR_ANGLE_INDEX] / 100 : 0;
            set => _values[REAR_LEFT_RADAR_ANGLE_INDEX] = value * 100;
        }

        public int FrontRightRadarAngle
        {
            get => _values.Length > FRONT_RIGHT_RADAR_ANGLE_INDEX ? _values[FRONT_RIGHT_RADAR_ANGLE_INDEX] / 100 : 0;
            set => _values[FRONT_RIGHT_RADAR_ANGLE_INDEX] = value * 100;
        }

        public int FrontLeftRadarAngle
        {
            get => _values.Length > FRONT_LEFT_RADAR_ANGLE_INDEX ? _values[FRONT_LEFT_RADAR_ANGLE_INDEX] / 100 : 0;
            set => _values[FRONT_LEFT_RADAR_ANGLE_INDEX] = value * 100;
        }

        private bool _isChanged;
        public bool IsChanged => _isChanged;

        public void ResetChangedState()
        {
            _isChanged = false;
        }

        public VEPBenchSynchroZone(int size = DEFAULT_SYNCHRO_SIZE)
        {
            _values = new int[size];
            ResetAllValues();
            _isChanged = false;
        }

        public static VEPBenchSynchroZone ReadFromVEP(Func<int, int, ushort[]> readFunc)
        {
            ushort[] part1 = readFunc(0, SYNCHRO_SIZE_PART1);
            ushort[] part2 = readFunc(SYNCHRO_SIZE_PART1, SYNCHRO_SIZE_PART2);

            if (part1.Length != SYNCHRO_SIZE_PART1 || part2.Length != SYNCHRO_SIZE_PART2)
                throw new ArgumentException("VEP에서 읽은 Synchro 데이터 크기가 올바르지 않습니다.");

            ushort[] all = new ushort[DEFAULT_SYNCHRO_SIZE];
            Array.Copy(part1, 0, all, 0, SYNCHRO_SIZE_PART1);
            Array.Copy(part2, 0, all, SYNCHRO_SIZE_PART1, SYNCHRO_SIZE_PART2);

            Instance.FromRegisters(all);
            return Instance;
        }

        public void FromRegisters(ushort[] registers)
        {
            if (registers == null)
                throw new ArgumentNullException(nameof(registers));

            bool changed = false;

            if (_values.Length != registers.Length)
            {
                _values = new int[registers.Length];
                changed = true;
            }

            for (int i = 0; i < registers.Length; i++)
            {
                if (_values[i] != registers[i])
                {
                    _values[i] = registers[i];
                    changed = true;
                }
            }

            if (changed)
            {
                _isChanged = true;
            }
        }

        public ushort[] ToRegisters()
        {
            ushort[] result = new ushort[_values.Length];

            for (int i = 0; i < _values.Length; i++)
            {
                result[i] = Convert.ToUInt16(_values[i]);
            }

            return result;
        }

        public void ResetAllValues()
        {
            for (int i = 0; i < _values.Length; i++)
            {
                _values[i] = 0;
            }
        }

        public void SetValue(int index, ushort value)
        {
            this[index] = value;
        }

        public int GetValue(int index)
        {
            return this[index];
        }
    }
}
