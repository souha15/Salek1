﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationPlateforme.Model.Orphelin
{
    public class PereOrphelin
    {

        public int Id { get; set; }
        public string nom { get; set; }
        public string cin { get; set; }
        public string travail { get; set; }
        public string alive { get; set; }
        public string datedeces { get; set; }
        public string raison { get; set; }
        public string lieudeces { get; set; }
        public string salaire { get; set; }
        public string nbfemme { get; set; }
        public string req { get; set; }
        public string nbenfant { get; set; }
        public string dateNais { get; set; }


        public int attribut1 { get; set; }
public int attribut7 { get; set; }
public string attribut2 { get; set; }
public string attribut3 { get; set; }
public string attribut4 { get; set; }
public string attribut5 { get; set; }
public string attribut6 { get; set; }
public string dateenreg { get; set; }

[ForeignKey("Orphelin")]
public int idOrph { get; set; }

public virtual Orphelin Orphelin { get; set; }
    }
}