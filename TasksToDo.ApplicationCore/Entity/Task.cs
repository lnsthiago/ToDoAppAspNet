using System;
using System.ComponentModel.DataAnnotations;
using TasksToDo.ApplicationCore.Enums;

namespace TasksToDo.ApplicationCore.Entity
{
    public class Task : Entity
    {
        [Display(Name = "Titulo")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Title { get; set; }

        [Display(Name = "Concluída")]
        public bool IsCompleted { get; set; }

        [Display(Name = "Status")]
        public TaskStatus Status { get; set; }

        [Display(Name = "Descrição")]
        public string Description { get; set; }

        [Display(Name = "Data de Criação")]
        public DateTime CreateDate { get; set; }

        [Display(Name = "Data de edição")]
        public DateTime? UpdateDate { get; set; }

        [Display(Name = "Data de remoção")]
        public DateTime? DeleteDate { get; set; }

        [Display(Name = "Data de conclusão")]
        public DateTime? DoneDate { get; set; }
    }
}
