using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;



namespace pet_hotel
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum PetBreedType
    {
        [EnumMember(Value = "breed")]
        Shepherd, Poodle, Beagle, Bulldog, Terrier, Boxer, Labrador, Retriever
    }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum PetColorType
    {
        [EnumMember(Value = "color")]
        White, Black, Golden, Tricolor, Spotted
    }
    public class Pet
    {

        public int id { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public PetBreedType breed { get; set; }

        [Required]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public PetColorType color { get; set; }

        public DateTime? checkedInAt { get; set; }

        [Required, ForeignKey("PetOwners")]
        public int petOwnerid { get; set; }

        public PetOwner petOwner { get; set; }


    }
}
