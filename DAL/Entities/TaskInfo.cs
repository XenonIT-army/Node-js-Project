namespace DAL.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Information")]
    public partial class TaskInfo
    {
        public int Id { get; set; }

        [Column("NAME")]
        [StringLength(20)]
        public string Name { get; set; }

        [Column("Text")]
        [StringLength(300)]
        public string Text { get; set; }

    }
}
