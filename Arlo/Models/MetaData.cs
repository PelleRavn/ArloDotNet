using System;
using System.Collections.Generic;

namespace Arlo.Models
{
    /*
     * "metaData": {
            "20191003": {
                "SMESQXG-207-32370302_A0B19272A88DF": {
                    "motion": {
                        "nonFavorite": {
                            "Other": 1
                        }
                    }
                }
            },
            "20191014": {
                "SMESQXG-207-32370302_A0B19272A88DF": {
                    "motion": {
                        "nonFavorite": {
                            "Person": 2
                        }
                    }
                }
            },
            "20191016": {
                "SMESQXG-207-32370302_A0B19272A88DF": {
                    "motion": {
                        "nonFavorite": {
                            "Person": 2
                        }
                    }
                }
            },
            "20191019": {
                "SMESQXG-207-32370302_A0B19377A80E3": {
                    "motion": {
                        "nonFavorite": {
                            "Animal": 1
                        }
                    }
                }
            }
        }

        Animal
        Person
        Package
        Vehicle
        Other
        Alarm

        */
    public class MetaData
    {
        public MetaData()
        {

        }

        public Dictionary<string, Dictionary<string, Motion>> DateDevice { get; set; }
    }

    public class Motion
    {
        public Dictionary<string, Dictionary<string, int>> Category { get; set; }
    }
}
