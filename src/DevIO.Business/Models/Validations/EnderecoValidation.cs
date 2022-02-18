using FluentValidation;

namespace DevIO.Business.Models.Validations
{
    public class EnderecoValidation : AbstractValidator<Endereco>
    {
        public EnderecoValidation()
        {
            RuleFor(c => c.Logradouro)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(2, 200).WithMessage("O campo {PropertyName} precisa ter entre {MinLenght} e {MaxCaracteres}");

            RuleFor(c => c.Bairro)
               .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
               .Length(2, 100).WithMessage("O campo {PropertyName} precisa ter entre {MinLenght} e {MaxCaracteres}");

            RuleFor(c => c.Cep)
               .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
               .Length(8).WithMessage("O campo {PropertyName} precisa ter entre {MinLenght} e {MaxCaracteres}");

            RuleFor(c => c.Cidade)
               .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
               .Length(2, 100).WithMessage("O campo {PropertyName} precisa ter entre {MinLenght} e {MaxCaracteres}");

            RuleFor(c => c.Estado)
               .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
               .Length(2, 50).WithMessage("O campo {PropertyName} precisa ter entre {MinLenght} e {MaxCaracteres}");

            RuleFor(c => c.Numero)
               .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
               .Length(1, 50).WithMessage("O campo {PropertyName} precisa ter entre {MinLenght} e {MaxCaracteres}");
        }
    }
}
