﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.UchetMedosmotrov3
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Список на медосм.
    /// </summary>
    // *** Start programmer edit section *** (СписокНаМедосм CustomAttributes)

    // *** End programmer edit section *** (СписокНаМедосм CustomAttributes)
    [AutoAltered()]
    [Caption("Список на медосм")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("СписокНаМедосмE", new string[] {
            "НомерДок as \'Номер документа\'",
            "Дата as \'Дата\'"})]
    [AssociatedDetailViewAttribute("СписокНаМедосмE", "КонтингентСотр", "КонтингентСотрE", true, "", "Контингент сотрудников", true, new string[] {
            ""})]
    [View("СписокНаМедосмL", new string[] {
            "НомерДок as \'Номер документа\'",
            "Дата as \'Дата\'"})]
    public class СписокНаМедосм : ICSSoft.STORMNET.DataObject
    {
        
        private int fНомерДок;
        
        private System.DateTime fДата = System.DateTime.Now;
        
        private IIS.UchetMedosmotrov3.DetailArrayOfКонтингентСотр fКонтингентСотр;
        
        // *** Start programmer edit section *** (СписокНаМедосм CustomMembers)

        // *** End programmer edit section *** (СписокНаМедосм CustomMembers)

        
        /// <summary>
        /// Дата.
        /// </summary>
        // *** Start programmer edit section *** (СписокНаМедосм.Дата CustomAttributes)

        // *** End programmer edit section *** (СписокНаМедосм.Дата CustomAttributes)
        public virtual System.DateTime Дата
        {
            get
            {
                // *** Start programmer edit section *** (СписокНаМедосм.Дата Get start)

                // *** End programmer edit section *** (СписокНаМедосм.Дата Get start)
                System.DateTime result = this.fДата;
                // *** Start programmer edit section *** (СписокНаМедосм.Дата Get end)

                // *** End programmer edit section *** (СписокНаМедосм.Дата Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (СписокНаМедосм.Дата Set start)

                // *** End programmer edit section *** (СписокНаМедосм.Дата Set start)
                this.fДата = value;
                // *** Start programmer edit section *** (СписокНаМедосм.Дата Set end)

                // *** End programmer edit section *** (СписокНаМедосм.Дата Set end)
            }
        }
        
        /// <summary>
        /// НомерДок.
        /// </summary>
        // *** Start programmer edit section *** (СписокНаМедосм.НомерДок CustomAttributes)

        // *** End programmer edit section *** (СписокНаМедосм.НомерДок CustomAttributes)
        public virtual int НомерДок
        {
            get
            {
                // *** Start programmer edit section *** (СписокНаМедосм.НомерДок Get start)

                // *** End programmer edit section *** (СписокНаМедосм.НомерДок Get start)
                int result = this.fНомерДок;
                // *** Start programmer edit section *** (СписокНаМедосм.НомерДок Get end)

                // *** End programmer edit section *** (СписокНаМедосм.НомерДок Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (СписокНаМедосм.НомерДок Set start)

                // *** End programmer edit section *** (СписокНаМедосм.НомерДок Set start)
                this.fНомерДок = value;
                // *** Start programmer edit section *** (СписокНаМедосм.НомерДок Set end)

                // *** End programmer edit section *** (СписокНаМедосм.НомерДок Set end)
            }
        }
        
        /// <summary>
        /// Список на медосм.
        /// </summary>
        // *** Start programmer edit section *** (СписокНаМедосм.КонтингентСотр CustomAttributes)

        // *** End programmer edit section *** (СписокНаМедосм.КонтингентСотр CustomAttributes)
        public virtual IIS.UchetMedosmotrov3.DetailArrayOfКонтингентСотр КонтингентСотр
        {
            get
            {
                // *** Start programmer edit section *** (СписокНаМедосм.КонтингентСотр Get start)

                // *** End programmer edit section *** (СписокНаМедосм.КонтингентСотр Get start)
                if ((this.fКонтингентСотр == null))
                {
                    this.fКонтингентСотр = new IIS.UchetMedosmotrov3.DetailArrayOfКонтингентСотр(this);
                }
                IIS.UchetMedosmotrov3.DetailArrayOfКонтингентСотр result = this.fКонтингентСотр;
                // *** Start programmer edit section *** (СписокНаМедосм.КонтингентСотр Get end)

                // *** End programmer edit section *** (СписокНаМедосм.КонтингентСотр Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (СписокНаМедосм.КонтингентСотр Set start)

                // *** End programmer edit section *** (СписокНаМедосм.КонтингентСотр Set start)
                this.fКонтингентСотр = value;
                // *** Start programmer edit section *** (СписокНаМедосм.КонтингентСотр Set end)

                // *** End programmer edit section *** (СписокНаМедосм.КонтингентСотр Set end)
            }
        }
        
        // *** Start programmer edit section *** (СписокНаМедосм.Отправить CustomAttributes)

        // *** End programmer edit section *** (СписокНаМедосм.Отправить CustomAttributes)
        [ICSSoft.STORMNET.AccessType(ICSSoft.STORMNET.AccessType.none)]
        public virtual void Отправить()
        {
            // *** Start programmer edit section *** (СписокНаМедосм.Отправить method implementation)
            return;
            // *** End programmer edit section *** (СписокНаМедосм.Отправить method implementation)
        }
        
        // *** Start programmer edit section *** (СписокНаМедосм.Печать CustomAttributes)

        // *** End programmer edit section *** (СписокНаМедосм.Печать CustomAttributes)
        [ICSSoft.STORMNET.AccessType(ICSSoft.STORMNET.AccessType.none)]
        public virtual void Печать()
        {
            // *** Start programmer edit section *** (СписокНаМедосм.Печать method implementation)
            return;
            // *** End programmer edit section *** (СписокНаМедосм.Печать method implementation)
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "СписокНаМедосмE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View СписокНаМедосмE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("СписокНаМедосмE", typeof(IIS.UchetMedosmotrov3.СписокНаМедосм));
                }
            }
            
            /// <summary>
            /// "СписокНаМедосмL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View СписокНаМедосмL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("СписокНаМедосмL", typeof(IIS.UchetMedosmotrov3.СписокНаМедосм));
                }
            }
        }
    }
}
