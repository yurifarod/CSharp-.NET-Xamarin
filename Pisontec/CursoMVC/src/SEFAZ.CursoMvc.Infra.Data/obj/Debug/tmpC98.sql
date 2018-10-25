CREATE TABLE [dbo].[Clientes] (
    [ClienteId] [uniqueidentifier] NOT NULL,
    [Nome] [nvarchar](max),
    [CPF] [nvarchar](max),
    [Email] [nvarchar](max),
    [DataCadastro] [datetime] NOT NULL,
    [DataNascimento] [datetime] NOT NULL,
    [Ativo] [bit] NOT NULL,
    CONSTRAINT [PK_dbo.Clientes] PRIMARY KEY ([ClienteId])
)
CREATE TABLE [dbo].[Enderecoes] (
    [EnderecoId] [uniqueidentifier] NOT NULL,
    [Logradouro] [nvarchar](max),
    [Numero] [nvarchar](max),
    [Bairro] [nvarchar](max),
    [CEP] [nvarchar](max),
    [Cidade] [nvarchar](max),
    [Estado] [nvarchar](max),
    [ClienteId] [uniqueidentifier] NOT NULL,
    CONSTRAINT [PK_dbo.Enderecoes] PRIMARY KEY ([EnderecoId])
)
CREATE INDEX [IX_ClienteId] ON [dbo].[Enderecoes]([ClienteId])
ALTER TABLE [dbo].[Enderecoes] ADD CONSTRAINT [FK_dbo.Enderecoes_dbo.Clientes_ClienteId] FOREIGN KEY ([ClienteId]) REFERENCES [dbo].[Clientes] ([ClienteId]) ON DELETE CASCADE
CREATE TABLE [dbo].[__MigrationHistory] (
    [MigrationId] [nvarchar](150) NOT NULL,
    [ContextKey] [nvarchar](300) NOT NULL,
    [Model] [varbinary](max) NOT NULL,
    [ProductVersion] [nvarchar](32) NOT NULL,
    CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY ([MigrationId], [ContextKey])
)
INSERT [dbo].[__MigrationHistory]([MigrationId], [ContextKey], [Model], [ProductVersion])
VALUES (N'201810191910176_AutomaticMigration', N'SEFAZ.CursoMvc.Infra.Data.Migrations.Configuration',  0x1F8B0800000000000400D55ACD6EE33610BE17E83B083AB545D64A762FDBC0DE45D6891741374E106717452F012D8D1DA214A91529C346D127EBA18FD457E8E85FA42C5BB2E26C8B5C6C92F371389C1FCEE7FCF3D7DFC3F76B9F592B0825157C649F0D4E6D0BB82B3CCA97233B528B576FEDF7EFBEFF6E78E5F96BEB4BBEEE4DBC0E25B91CD94F4A05E78E23DD27F0891CF8D40D85140B357085EF104F38AF4F4F7F76CECE1C40081BB12C6B781F71457D48BEE0D7B1E02E042A22EC4678C064368E33B304D59A121F64405C18D9B3ABC9C56F8371144A71B37207D77C1192C125516480280AD6CAB62E1825A8D80CD8C2B608E74211856A9F7F963053A1E0CB598003843D6C02C0750BC22464C7392F97B73DD9E9EBF8644E299843B99154C2EF0878F6263395638A1F6470BB30251AF30A8DAE36F1A913838EEC31A38036B32D73AFF3310BE37535735FE22ACA0709120539C8104EACADEB4E0A8F41C78AFF4EAC71C45414C28843A442C24EACBB68CEA8FB0B6C1EC4EFC0473C62ACAA34AA8D73DA000EDD852280506DEE61A11FE5DAB32D4717774CF942BA2E9A9EF96344F1F314352173068583383B51A6C2871C00BD0CE3C7B66EC8FA13F0A57A1AD9F8D1B626740D5E3E92A17EE614C30D855418EDDD647C3739FA1E577873ECE8BBC4113B261E911890F96638060F34366347DBC76053225D94E5AA3FDC85A2AB02E583100C08DF0F32252BBA4CA2C73428F720045748DBBA0796AC904F344813D4209F7D2C8271120AFF5EB08A643EF7F840C22560867B100D0B66220A5D43B7A15306FECE7490A3F5C80739C4B74F08B926876484AA6C8F94F0492C43CCC751E9E1470BA769E4C30B6CF381D0F005B6195FDD1D7F0FEA11EFF819FB4A2A7481E39FE6B01AD698B38A64D43763E509A93163E529AD4DC6BA9052B834D1C788D44217FD7C386DED532CBD98EAC1F07E3029D100D3102A31B27FAAD96D076E91A24BDCC24E3AEC996D66B15B7E090C1458176EFA601C63514BBCD4CC60B8AD3E82890FF5E0F1B316DFC1585531DBAA7A96A4DCA501617B9437E4BA3DB862F58A8DCC994B080037E56ACFB5F4D6A0D8C830DC3E3B0D9D8A93D5AB65DC63A00484B90E597D2B7A8F5AE5C4A6232B9E320B65D39562DC1928FD54F8582863C0F4A39A37EA109507470DA3F47103A472EC3A5219EA95654DE9C0BC8B1641589C4053BE76AB2DC2AE82545AD28C1EFDAC5B124F71CD6527EAA4AD68DEB23A0D3DEBF0860401E6F84A0F9B8D58B3B4811DBF9A756FE5FC14C371E5968EAED0B6D84989902CC198C5AD51D3090DA58A1FCC73121784B1E7D797194EDDE06DF96E86DFD62F2D77C15C20FE9C0AED6DE6070D4E559A7582278D9FFDC9A1A17EFD75C98456208C84CD35742C58E4F3BD69A6192BED06AB30E9487B84A4D5D3F48807DACB676D5C15211B6A8FA1376955287DA61B62B5533331AB73ED51B386AD0A960DD531868EE138B5D25173D85AEDD503A055789469ED79E3A3C8E7DD03A459B4D1A72A7D91E6588DBDD62EB46A7B5445AB8E7788B8AC03D2622E1B6B8F92373855947CAC43ECC6FD8B16BBF14007F9AC37D120B2B10E19206B3DB49BCAC63AE87240563C6A8CD56AB4B9A4D8BDA8D5464D1E66F5713FD95C2B98E912DB4223ADA81717CBD9462AF0D3A09C7D65A95DCA053784D3054895921936D6F3B70641FDDF218B1D293DD68E31FEC60C6DC4E9D70868FCBEA70B0A612FB696AF48E83E91F0079FAC7FAC227564647BE168AC6B2FA46DCCAA4714A8E763560F86D398D539557B00BA3397DF9C28ECED9975D2B09737E8C4602F289DFCEB173525C1D70F4723F1FA05A046D4F5D36A7FBAAAD104D7E849EB91FD4702716E5DFFFA58A09C58B721BAD9B9756AFD7960C0F420CE8ACEFF8509AD7AAF7F2057771033D6DC761E9B09FBFF505F3532A115B1B58BD74A5F57585FE6F165A75EDEC8E234B15E3B49AF6D3BE4B35BF6780952CCB08BC65DB4A1C0B6B267C7E1BCEAEF66F4AACABF72A0534BBA2C21E27FECE0E06AFE54ACC16656E49E6D68942F31F2EA0D608A4667BB08318D1257E1B40B5226BFA87C212C4A9E5173F0AEF96DA48248E191C19FB34DD5187178ECDA3F21F6749D87B741F20BC8731C01D5A4F1EBE9967F8828F30ABD275B727903441C771F01C7D3BBC43056B0DC144853C15B0265E62BD2C503F801433079CB67640587E8F659C22758127793B73FCD20FB2F4237FBF092127C19F932C328E5F12BFAB0E7AFDFFD0B3EFADCD7D1240000 , N'6.2.0-61023')

