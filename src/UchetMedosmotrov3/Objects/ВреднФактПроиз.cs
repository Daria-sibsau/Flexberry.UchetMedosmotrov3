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
    /// Вредн факт произ.
    /// </summary>
    // *** Start programmer edit section *** (ВреднФактПроиз CustomAttributes)

    // *** End programmer edit section *** (ВреднФактПроиз CustomAttributes)
    [AutoAltered()]
    [Caption("Произ")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ВреднФактПроизE", new string[] {
            "Номер as \'Номер\'",
            "КлассВредФакт as \'Вредные факторы\'",
            "КлассВредФакт.Наименование as \'Наименование\'"}, Hidden=new string[] {
            "КлассВредФакт.Наименование"})]
    [MasterViewDefineAttribute("ВреднФактПроизE", "КлассВредФакт", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Наименование")]
    public class ВреднФактПроиз : ICSSoft.STORMNET.DataObject
    {
        
        private int fНомер;
        
        private IIS.UchetMedosmotrov3.КлассВредФакт fКлассВредФакт;
        
        private IIS.UchetMedosmotrov3.ИндНапрМедосм fИндНапрМедосм;
        
        // *** Start programmer edit section *** (ВреднФактПроиз CustomMembers)

        // *** End programmer edit section *** (ВреднФактПроиз CustomMembers)

        
        /// <summary>
        /// Номер.
        /// </summary>
        // *** Start programmer edit section *** (ВреднФактПроиз.Номер CustomAttributes)

        // *** End programmer edit section *** (ВреднФактПроиз.Номер CustomAttributes)
        public virtual int Номер
        {
            get
            {
                // *** Start programmer edit section *** (ВреднФактПроиз.Номер Get start)

                // *** End programmer edit section *** (ВреднФактПроиз.Номер Get start)
                int result = this.fНомер;
                // *** Start programmer edit section *** (ВреднФактПроиз.Номер Get end)

                // *** End programmer edit section *** (ВреднФактПроиз.Номер Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ВреднФактПроиз.Номер Set start)

                // *** End programmer edit section *** (ВреднФактПроиз.Номер Set start)
                this.fНомер = value;
                // *** Start programmer edit section *** (ВреднФактПроиз.Номер Set end)

                // *** End programmer edit section *** (ВреднФактПроиз.Номер Set end)
            }
        }
        
        /// <summary>
        /// Вредн факт произ.
        /// </summary>
        // *** Start programmer edit section *** (ВреднФактПроиз.КлассВредФакт CustomAttributes)

        // *** End programmer edit section *** (ВреднФактПроиз.КлассВредФакт CustomAttributes)
        [PropertyStorage(new string[] {
                "КлассВредФакт"})]
        [NotNull()]
        public virtual IIS.UchetMedosmotrov3.КлассВредФакт КлассВредФакт
        {
            get
            {
                // *** Start programmer edit section *** (ВреднФактПроиз.КлассВредФакт Get start)

                // *** End programmer edit section *** (ВреднФактПроиз.КлассВредФакт Get start)
                IIS.UchetMedosmotrov3.КлассВредФакт result = this.fКлассВредФакт;
                // *** Start programmer edit section *** (ВреднФактПроиз.КлассВредФакт Get end)

                // *** End programmer edit section *** (ВреднФактПроиз.КлассВредФакт Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ВреднФактПроиз.КлассВредФакт Set start)

                // *** End programmer edit section *** (ВреднФактПроиз.КлассВредФакт Set start)
                this.fКлассВредФакт = value;
                // *** Start programmer edit section *** (ВреднФактПроиз.КлассВредФакт Set end)

                // *** End programmer edit section *** (ВреднФактПроиз.КлассВредФакт Set end)
            }
        }
        
        /// <summary>
        /// мастеровая ссылка на шапку IIS.UchetMedosmotrov3.ИндНапрМедосм.
        /// </summary>
        // *** Start programmer edit section *** (ВреднФактПроиз.ИндНапрМедосм CustomAttributes)

        // *** End programmer edit section *** (ВреднФактПроиз.ИндНапрМедосм CustomAttributes)
        [Agregator()]
        [NotNull()]
        [PropertyStorage(new string[] {
                "ИндНапрМедосм"})]
        public virtual IIS.UchetMedosmotrov3.ИндНапрМедосм ИндНапрМедосм
        {
            get
            {
                // *** Start programmer edit section *** (ВреднФактПроиз.ИндНапрМедосм Get start)

                // *** End programmer edit section *** (ВреднФактПроиз.ИндНапрМедосм Get start)
                IIS.UchetMedosmotrov3.ИндНапрМедосм result = this.fИндНапрМедосм;
                // *** Start programmer edit section *** (ВреднФактПроиз.ИндНапрМедосм Get end)

                // *** End programmer edit section *** (ВреднФактПроиз.ИндНапрМедосм Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ВреднФактПроиз.ИндНапрМедосм Set start)

                // *** End programmer edit section *** (ВреднФактПроиз.ИндНапрМедосм Set start)
                this.fИндНапрМедосм = value;
                // *** Start programmer edit section *** (ВреднФактПроиз.ИндНапрМедосм Set end)

                // *** End programmer edit section *** (ВреднФактПроиз.ИндНапрМедосм Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ВреднФактПроизE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ВреднФактПроизE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ВреднФактПроизE", typeof(IIS.UchetMedosmotrov3.ВреднФактПроиз));
                }
            }
        }
    }
    
    /// <summary>
    /// Detail array of ВреднФактПроиз.
    /// </summary>
    // *** Start programmer edit section *** (DetailArrayDetailArrayOfВреднФактПроиз CustomAttributes)

    // *** End programmer edit section *** (DetailArrayDetailArrayOfВреднФактПроиз CustomAttributes)
    public class DetailArrayOfВреднФактПроиз : ICSSoft.STORMNET.DetailArray
    {
        
        // *** Start programmer edit section *** (IIS.UchetMedosmotrov3.DetailArrayOfВреднФактПроиз members)

        // *** End programmer edit section *** (IIS.UchetMedosmotrov3.DetailArrayOfВреднФактПроиз members)

        
        /// <summary>
        /// Construct detail array.
        /// </summary>
        /// <summary>
        /// Returns object with type ВреднФактПроиз by index.
        /// </summary>
        /// <summary>
        /// Adds object with type ВреднФактПроиз.
        /// </summary>
        public DetailArrayOfВреднФактПроиз(IIS.UchetMedosmotrov3.ИндНапрМедосм fИндНапрМедосм) : 
                base(typeof(ВреднФактПроиз), ((ICSSoft.STORMNET.DataObject)(fИндНапрМедосм)))
        {
        }
        
        public IIS.UchetMedosmotrov3.ВреднФактПроиз this[int index]
        {
            get
            {
                return ((IIS.UchetMedosmotrov3.ВреднФактПроиз)(this.ItemByIndex(index)));
            }
        }
        
        public virtual void Add(IIS.UchetMedosmotrov3.ВреднФактПроиз dataobject)
        {
            this.AddObject(((ICSSoft.STORMNET.DataObject)(dataobject)));
        }
    }
}
