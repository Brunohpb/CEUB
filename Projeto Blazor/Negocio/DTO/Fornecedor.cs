using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Sistec
{
    [Table ("TB_Fornecedor")]
    public class Fornecedor
    {
        [Key]
        public int USUID{get;set;}
        public string USULOGIN{get;set;}
        public string USUEMAIL{get;set;}
        public string USUNOMECOMPLETO{get;set;}
        public string USUSENHA{get;set;}
        public DateTime USUDATAHORACRIACAO{get;set;}
        public bool USUATIVO{get;set;}
        public string USUCNPJ{get;set;}
        public string USUTELEFONE {get;set;}
    }

    /*
    create table DBO.TB_Fornecedor (
    USUID                numeric              identity(1, 1),
    USULOGIN             varchar(100)         collate SQL_Latin1_General_CP850_CI_AI not null,
    USUEMAIL             varchar(100)         collate SQL_Latin1_General_CP850_CI_AI not null,
    USUNOMECOMPLETO      varchar(100)         collate SQL_Latin1_General_CP850_CI_AI not null,
    USUSENHA             varchar(256)         collate SQL_Latin1_General_CP850_CI_AI not null,
    USUDATAHORACRIACAO   datetime             not null constraint DF__fornecedor_usudata__2C5E7C59 default getdate(),
    USUATIVO             bit                  not null constraint DF__fornecedor_usuativ__2D52A092 default (1),
    USUCNPJ              varchar(20)          null,
    USUTELEFONE          varchar(15)          null,
    constraint PK_Fornecedor primary key nonclustered (USUID),
    constraint AK_Fornecedor_login unique (USULOGIN)
    )
    */

    public class CEP1
    {
        public string cep{get;set;}
        public string logradouro{get;set;}
        public string complemento{get;set;}
        public string bairro{get;set;}
        public string localidade{get;set;}
        public string uf{get;set;}
        public string ibge{get;set;}
        public string gia{get;set;}
        public string ddd{get;set;}
        public string siafi{get;set;}
    }
    
}
