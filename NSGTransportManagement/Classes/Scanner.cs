using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using WIA;

namespace NSGTransportManagement.Classes
{
    class Scanner
    {
        Device oDevice;
        Item oItem;
        CommonDialog dlg;

        public Scanner()
        {
            //dlg = new CommonDialog();
            //oDevice = dlg.ShowSelectDevice(WiaDeviceType.ScannerDeviceType, true, false);
        }

        public ImageFile Scann()
        {
            try
            {
                CommonDialog dialog = new CommonDialog();

                ImageFile image = dialog.ShowAcquireImage(
                    WiaDeviceType.ScannerDeviceType,
                    WiaImageIntent.ColorIntent,
                    WiaImageBias.MaximizeQuality,
                    FormatID.wiaFormatJPEG, false, false, false);

                return image;
            }
            catch (COMException ex)
            {
                if (ex.ErrorCode == -2145320939)
                {
                    throw new Exception("Scanner not found");
                    //throw new ScannerNotFoundException();
                }
                else
                {
                    throw new Exception("COM Exception", ex);
                }
            }
            //dlg.ShowAcquisitionWizard(oDevice);
        }
    }
}
