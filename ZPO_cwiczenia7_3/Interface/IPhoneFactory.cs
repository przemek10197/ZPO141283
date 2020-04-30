using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZPO_cwiczenia7_3.Class;

namespace ZPO_cwiczenia7_3.Interface
{
    interface IPhoneFactory
    {
        OperationalSystem SetOperationalSystem();
        CameraResolution SetCameraResolution();
        ScreenDiagonal SetScreenDiagonal();
        NFC SetNFC();
        BatteryCapacity SetBatteryCapacity();
    }
}
