﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EFGeneric.Base.Entity;

namespace Domain.Domain
{
    [Table("T_COURSE")]
    public class Course : BaseDEntity<long>
    {

        [Column("ID")]
        public override long Id { get; set; }

        [Column("IS_DELETED")]
        public Nullable<bool> IsDeleted { get; set; }

        [Column("NAME")]
        public string Name { get; set; }

        [Required]
        [Column("CREATE_DATE")]
        public DateTime CreateDate { get; set; }

        public virtual List<Student> Students { get; set; }

        public Course()
        {
            IsDeleted = false;
            CreateDate = DateTime.Now;
            Students = new List<Student>();
        }

        public Course(string name)
        {
            IsDeleted = false;
            CreateDate = DateTime.Now;
            Name = name;
        }
        
    }
}
