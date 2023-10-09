namespace CadastroPaciente.Domain.Entities;
public class ProviderEntity : BaseEntity
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Cpf_Or_Cnpj { get; set; }
    public string Sexo { get; set; }
    public bool Active { get; set; }
    public string Thumbnail { get; set; }    
}