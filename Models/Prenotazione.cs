using System;
using System.ComponentModel.DataAnnotations;

namespace Bertozzi.Mattia._5H.FormWeb.Models
{
    public class Prenotazione
    {
        public string? Nome{get;set;}

        [Required(ErrorMessage="Inserisci un email valida")]
        [EmailAddress]
        public string? Email{get;set;}

    }
}