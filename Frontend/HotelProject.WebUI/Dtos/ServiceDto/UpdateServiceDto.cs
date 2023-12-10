﻿using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
    public class UpdateServiceDto
    {
        public int ServiceID { get; set; }

        [Required(ErrorMessage = "Hizmet Ikon Linki Giriniz")]
        public string ServiceIcon { get; set; }

        [Required(ErrorMessage = "Hizmet Basligi Giriniz")]
        [StringLength(100, ErrorMessage = "Hizmet Basligi En Fazla 100 Karakter Olabilir")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Hizmet Aciklamasi Giriniz")]
        [StringLength(500, ErrorMessage = "Hizmet Basligi En Fazla 500 Karakter Olabilir")]
        public string Description { get; set; }
    }
}
