using FluentValidation;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiTest.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        [JsonProperty("model_year")]
        public int ModelYear { get; set; }
    }

    public class CarValidator : AbstractValidator<Car> {
        public CarValidator()
        {
            RuleFor(x => x.Id).NotNull();
            RuleFor(x => x.Name).Length(1, 20);
            RuleFor(x => x.Model).Length(1, 20);
            RuleFor(x => x.ModelYear).InclusiveBetween(1900, 2019);
        }
    }

}
