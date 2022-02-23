using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace pet_hotel
{
    public enum PetBreedType {}
    public enum PetColorType {}
    public class Pet {
    
        public int id {get; set;}

        [Required]
        public string name {get; set;}
        [Required]
        public PetBreedType breed {get; set;}
        public DateTime checkedInAt {get; set;}

        [Required, ForeignKey("PetOwners")]
        public int petOwnerid {get; set;}

        
    }
}
