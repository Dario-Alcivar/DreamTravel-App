/*
Author: Ibraheem
Purpose: Get booking history for customers
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using TeamLID.TravelExperts.Repository.Domain;

namespace TeamLID.TravelExperts.App.Models
{
    //// <summary>
    /// Booking model
    /// </summary>
    public class BookingsModel
    {
        public int BookingId { get; set; }

        [DataType(DataType.Date), DisplayName("Fecha de reserva")]
        public DateTime? BookingDate { get; set; }

        [DataType(DataType.Date), DisplayName("TFecha Inicio de viaje")]
        public DateTime? PkgStartDate { get; set; }

        [DataType(DataType.Date), DisplayName("Fecha Fin de viaje")]
        public DateTime? PkgEndDate { get; set; }

        [DisplayName("Descripción de viaje")]
        public string PkgDesc { get; set; }

        [DisplayName("Número de reserva")]
        public string BookingNo { get; set; }

        [DisplayName("Número de viajeros")]
        public double? TravelerCount { get; set; }

        [DisplayName("Cliente")]
        public string CustomerId { get; set; }

        [DisplayName("Tipo de viaje")]
        public string TripTypeId { get; set; }

        [DisplayName("Paquete reservado")]
        public string PackageId { get; set; }

        [DataType(DataType.Currency), DisplayName("Precio (US$)")]
        public decimal Price { get; set; }

        [DisplayName("Total")]
        public string Total { get; set; }
    }
}
