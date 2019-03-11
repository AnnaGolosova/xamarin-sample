using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.UITest;

namespace UITest
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            if (platform == Platform.Android)
            {
                return ConfigureApp
                    .Android
                    .InstalledApp("anaware.samples.listviewsample")

                    // To run tests on the device, type here your device serial number.
                    // To get serial number run 'adb devices' command in the command prompt
                    // You need to ensure that your device isn't in 'offline' mode. To fix it select 'File transfering' usb connection mode
                    //.DeviceSerial("1164546552")
                    .StartApp();
            }

            return ConfigureApp
                .iOS
                //To Run tests on the IOS device, select .app file
                //.AppBundle("../../../iOSAppProject/bin/iPhoneSimulator/Debug/iosapp.app")
                //.DeviceIdentifier("7A02B0D2-98E4-4820-A49A-818995DC9837")

                .StartApp();
        }
    }
}
