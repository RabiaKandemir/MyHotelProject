﻿using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
    public class CreateServiceDto
    {
        [Required(ErrorMessage ="Hizmet ikon linki giriniz")]
        public string ServiceIcon { get; set; }
        [Required(ErrorMessage = "Hizmet bağlığı giriniz")]
        [StringLength(100,ErrorMessage ="Hizmet başlığı en fazla 100 karakter olmalıdır")]
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
