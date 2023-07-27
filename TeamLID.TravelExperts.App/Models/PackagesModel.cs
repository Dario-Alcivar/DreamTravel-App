/*
Author: Ibraheem
Purpose: Get packages
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TeamLID.TravelExperts.App.Models
{
    /// <summary>
    /// Packages model.
    /// </summary>
    public class PackagesModel
    {
        public int PackageId { get; set; }

        [DisplayName("Titulo")]
        public string PkgName { get; set; }

        [DataType(DataType.Date), DisplayName("Fecha Inicio")]
        public DateTime? PkgStartDate { get; set; }

        [DataType(DataType.Date), DisplayName("Fecha Fin")]
        public DateTime? PkgEndDate { get; set; }

        [DisplayName("Descripcion")]
        public string PkgDesc { get; set; }

        [DisplayName("Precio (US$)")]
        public string PkgBasePrice { get; set; }
    }
}
