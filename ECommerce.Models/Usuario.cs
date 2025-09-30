using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Models
{
    /*
     * Tabela: nome da classe no singular
     * Id - Ef identica a chave primária(PK)
     * com o null!
     * a compilação não reclama mais
     * porém o migration cria a coluna como NOT NULL
     * o banco cuida da verificação dos campos obrigatórios na hora de salvar
     */
    public class Usuario
    {
        public int Id { get; set; }

        public string Nome { get; set; } = null!;

        public string? Email { get; set; } = null!;

        public string? Sexo { get; set; }

        public string? CPF { get; set; } = null!;

        public string? RG { get; set; }

        public string? NomeMae { get; set; }

        public string? SituacaoCadastro { get; set; }

        public DateTimeOffset DataCadastro { get; set; }

        public Contato? Contato { get; set; }

        public ICollection<EnderecoEntrega>? EnderecosEntrega { get; set; }

        public ICollection<Departamento> Departamento { get; set; }         

    }
}
