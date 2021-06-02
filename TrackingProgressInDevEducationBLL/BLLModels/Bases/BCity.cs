﻿using System.Collections.Generic;
using TrackingProgressInDevEducationDAL.Models.Bases;
using AutoMapper;

namespace TrackingProgressInDevEducationBLL.BLLModels.Bases
{
    public class BCity : BAbstractModel
    {
        public string Name { get; set; }

        public BCity()
        {
        }

        public BCity(City city)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<City, BCity>());
            Mapper mapper = new Mapper(config);

            BCity tmpBCity = new BCity();
            tmpBCity = mapper.Map<BCity>(city);
            if (tmpBCity.Name != null)
            {
                this.Name = tmpBCity.Name;
            }
        }

        public List<BCity> GetCities(List<City> cities)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<List<City>, List<BCity>>());
            Mapper mapper = new Mapper(config);

            List<BCity> tmpBCities = new List<BCity>();
            tmpBCities = mapper.Map<List<BCity>>(cities);
            foreach (var c in cities)
            {
                if (c.Name != null)
                {

                }
            }

            return tmpBCities;
        }
        public override bool Equals(object obj)
        {
            return Equals((BCity)obj);
        }

        private bool Equals(BCity other)
        {
            return Name == other.Name;
        }

        public override int GetHashCode()
        {
            return (Name != null ? Name.GetHashCode() : 0);
        }
    
    }

    //var config = new MapperConfiguration(cfg => cfg.CreateMap<Empl, Person>()
    //.ForMember(dest => dest.FullName, option => option.MapFrom(sorse => sorse.Name + sorse.LastName)));
    //Mapper mapper = new Mapper(config);

    //Empl empl = new Empl() { Name = "QQQ", LastName="qqq", Age = 100, Position = "QQQist" }

    //Person person = mapper.Map<Person>(empl);
}
