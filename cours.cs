
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------


namespace dotnet
{

using System;
    using System.Collections.Generic;
    
public partial class cours
{

    public Nullable<int> id_ec { get; set; }

    public Nullable<int> id_personnel { get; set; }

    public int id { get; set; }

    public string nom { get; set; }

    public Nullable<int> id_type { get; set; }

    public Nullable<int> volume_horraire { get; set; }



    public virtual ec ec { get; set; }

    public virtual personnel personnel { get; set; }

    public virtual type_cours type_cours { get; set; }

}

}
