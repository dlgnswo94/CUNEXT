namespace CUNEXT
{
    namespace Utility
    {
        namespace Enum
        {
            public enum EFileNameExtension
            {
                // If you add the type manually, be careful! Be sure to add enum by classification.
                None = 0,

                #region Documents related < 0 ~ 99 >
                txt = 1,
                doc,
                docx,
                pdf,
                ppt,
                pptx,
                xml,
                xls,
                xlsm,
                xlsx,
                #endregion Documents related < 0 ~ 99 >

                #region Image related < 100 ~ 199 >
                jpeg = 100,
                jpg,
                png,
                psd,
                gif,
                bmp,
                tiff,
                raw,
                #endregion Image related < 100 ~ 199 >

                #region Sound related < 200 ~ 299 >
                wav = 200,
                wma,
                mp3,
                #endregion Sound related < 200 ~ 299 >

                #region Modeling related < 300 ~ 399 >
                fbx = 300,
                dae,
                dxf,
                obj,
                #endregion Modeling related < 300 ~ 399 >

                #region Video related < 400 ~ 499 >
                mp4 = 400,
                avi,
                wmv,
                mkv,
                mov,
                #endregion Video related < 400 ~ 499 >

                #region C#, C++, C related < 1000 ~ 1099 >
                cs = 1000,
                cpp,
                c,
                #endregion C#, C++, C related < 1000 ~ 1099 >

                // When using Custom Extension, make sure to annotate which role the extension is!
                #region Custom Extension < 10000 ~ >

                #endregion Custom Extension < 10000 ~ >
                // When using Custom Extension, make sure to annotate which role the extension is!
            }
        }
    }
}