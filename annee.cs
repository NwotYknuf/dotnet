
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
    
public partial class annee
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public annee()
    {

        this.periode = new HashSet<periode>();

    }


    public Nullable<int> id_diplome { get; set; }

    public int id { get; set; }

    public string nom { get; set; }

    public string description { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<periode> periode { get; set; }

    public virtual diplome diplome { get; set; }

}

}
