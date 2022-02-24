using System.Collections.Generic;
using System;
// using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace pet_hotel
{
    // [JsonConverter(typeof(StringEnumConverter))]

    public enum PetBreedType {
        [EnumMember(Value = "breed")]
        Shepherd, Poodle, Beagle, Bulldog, Terrier, Boxer, Labrador, Retriever
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum PetColorType {
        [EnumMember(Value = "color")]
        White, Black, Golden, Tricolor, Spotted
    }
    public class Pet {
    
        public int id {get; set;}

        [Required]
        public string name {get; set;}
        
        [Required]
        // [JsonProperty("breed")]
        // [JsonConverter(typeof(JsonStringEnumConverter))]
        public PetBreedType breed {get; set;}
        
        [Required]
        // [JsonProperty("color")]
        // [JsonConverter(typeof(StringEnumConverter))]
        public PetColorType color {get; set;}
        
        public DateTime? checkedInAt {get; set;}

        [Required, ForeignKey("PetOwners")]
        public int petOwnerid {get; set;}

        public PetOwner petOwner {get; set;}

        
    }
}
