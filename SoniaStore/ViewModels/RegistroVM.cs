using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SoniaStore.ViewModels
{
    public class RegistroVM
    {
        [Display(Name = "Nome Completo", Prompt = "Informe seu nome completo")]
        [Required(ErrorMessage = "Por favor, informe seu nome")]
        [StringLength(60, ErrorMessage = "O Nome deve possuir no maximo 60 caracteres")]
        public string Nome { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data de Nascimento", Prompt = "Informe sua data de nascimento")]
        [Required(ErrorMessage = "Por favor, informe sua data de nascimento")]
        public DateTime? DataNascimento { get; set; } = null;

        [Display(Prompt = "Informe seu Email")]
        [Required(ErrorMessage = "Por favor, informe seu email")]
        [EmailAddress(ErrorMessage = "Por favor, informe um email válido")]
        [StringLength(100, ErrorMessage = "O email deve possuir no maximo 100 caracteres")]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Senha de Acesso", Prompt = "Informe sua senha de acesso")]
        [Required(ErrorMessage = "Por favor, informe sua senha de acesso")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "A senha deve possuir no minimo 6 e no máximo 20 caracteres")]
        public string Senha { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmar senha de acesso", Prompt = "Confirme sua senha de acesso")]
        [Compare("Senha", ErrorMessage = "As senhas não conferem")]
        public string ConfirmacaoSenha { get; set; }

        public IFormFile Foto { get; set; }
    }
}