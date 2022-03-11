﻿namespace CRUDFilesGenerator
{
    public class FileGenerator
    {
        private string _featureName;
        private string _moduleName;
        private string _projectName;
        private string _dir;
        public FileGenerator(string projectName, string featureName, string moduleName, string dir)
        {
            _featureName = featureName;
            _moduleName = moduleName;
            _projectName = projectName;
            _dir = dir;
        }

        public async void Generate()
        {
            if (char.IsUpper(_featureName[0]) == false)
            {
                throw new Exception("A primeira letra de uma feature deve ser maiúscula");
            }

            if (char.IsUpper(_moduleName[0]) == false)
            {
                throw new Exception("A primeira letra de um module deve ser maiúscula");
            }

            GenerateEntity();
            GenerateMap();
            GenerateRepository();
            GenerateUnitOfWork();
            GenerateController();
            GenerateService();
            GenerateMappers();
            GenerateValidations();
            GenerateTestsMocks();
            GenerateTestsModules();

            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Arquivos gerados com sucesso!");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||||||||");
            Console.WriteLine("******************************************************");
        }

        private async void GenerateEntity()
        {
            string dir = _dir + _projectName + @"Domain\Entities\" + _featureName + @"\" + _moduleName + @"Ctx\";
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            var fileDir = dir + _moduleName + ".cs";
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Gerando arquivo de entidade!");
            
            await File.WriteAllTextAsync(fileDir, "");
            
            Console.WriteLine("Arquivo gerado com sucesso!");
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------");
        }
        private async void GenerateMap()
        {
            string dir = _dir + _projectName + @"Infrastructure\Persistence\Map\" + _featureName + @"\" + _moduleName + @"Ctx\";
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            var fileDir = dir + _moduleName + "Map.cs";
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Gerando arquivo de mapeamento!");

            await File.WriteAllTextAsync(fileDir, "");

            Console.WriteLine("Arquivo gerado com sucesso!");
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------");
        }
        private async void GenerateRepository()
        {
            string dir = _dir + _projectName + @"Infrastructure\Persistence\Repository\" + _featureName + @"\" + _moduleName + @"Ctx\";
            string interfaceDir = dir + @"Interfaces\";

            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            if (!Directory.Exists(interfaceDir))
            {
                Directory.CreateDirectory(interfaceDir);
            }

            var fileDir = dir + _moduleName + "Repository.cs";
            var iFileDir = interfaceDir + "I" + _moduleName + "Repository.cs";
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Gerando arquivo de repository!");

            await File.WriteAllTextAsync(fileDir, "");
            await File.WriteAllTextAsync(iFileDir, "");

            Console.WriteLine("Arquivo gerado com sucesso!");
            Console.WriteLine("Interface gerada com sucesso!");
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------");
        }
        private async void GenerateUnitOfWork()
        {
            string dir = _dir + _projectName + @"Infrastructure\Persistence\UnitOfWork\" + _featureName + @"\" + _moduleName + @"Ctx\";
            string interfaceDir = dir + @"Interfaces\";

            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            if (!Directory.Exists(interfaceDir))
            {
                Directory.CreateDirectory(interfaceDir);
            }

            var fileDir = dir + _moduleName + "UnitOfWork.cs";
            var iFileDir = interfaceDir + "I" + _moduleName + "UnitOfWork.cs";
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Gerando arquivo de unit of work!");

            await File.WriteAllTextAsync(fileDir, "");
            await File.WriteAllTextAsync(iFileDir, "");

            Console.WriteLine("Arquivo gerado com sucesso!");
            Console.WriteLine("Interface gerada com sucesso!");
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------");
        }
        private async void GenerateController()
        {
            string dir = _dir + _projectName + @"Interface\Controllers\" + _featureName + @"\" + _moduleName + @"Ctx\";

            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            var fileDir = dir + _moduleName + "Controller.cs";
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Gerando arquivo de controller!");

            await File.WriteAllTextAsync(fileDir, "");

            Console.WriteLine("Arquivo gerado com sucesso!");
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------");
        }
        private async void GenerateService()
        {
            string dir = _dir + _projectName + @"Service\Modules\" + _featureName + @"\" + _moduleName + @"Ctx\";
            string interfaceDir = dir + @"Interfaces\";

            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            if (!Directory.Exists(interfaceDir))
            {
                Directory.CreateDirectory(interfaceDir);
            }

            var fileDir = dir + _moduleName + "ApplicationService.cs";
            var iFileDir = interfaceDir + "I" + _moduleName + "ApplicationService.cs";
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Gerando arquivo de application service!");

            await File.WriteAllTextAsync(fileDir, "");
            await File.WriteAllTextAsync(iFileDir, "");

            Console.WriteLine("Arquivo gerado com sucesso!");
            Console.WriteLine("Interface gerada com sucesso!");
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------");
        }
        private async void GenerateMappers()
        {
            string dir = _dir + _projectName + @"Service\Mappers\" + _featureName + @"\" + _moduleName + @"Ctx\";

            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            var fileDir = dir + _moduleName + "Mapper.cs";
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Gerando arquivo de mapper!");

            await File.WriteAllTextAsync(fileDir, "");

            Console.WriteLine("Arquivo gerado com sucesso!");
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------");
        }
        private async void GenerateValidations()
        {
            string dir = _dir + _projectName + @"Service\Validations\Modules\" + _featureName + @"\" + _moduleName + @"Ctx\";

            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            var fileDir = dir + _moduleName + "Validator.cs";
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Gerando arquivo de validator!");

            await File.WriteAllTextAsync(fileDir, "");

            Console.WriteLine("Arquivo gerado com sucesso!");
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------");
        }
        private async void GenerateTestsMocks()
        {
            string dir = _dir + _projectName + @"Service.Tests\Mockups\" + _featureName + @"\" + _moduleName + @"Ctx\";

            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            var fileDir = dir + _moduleName + "Mocks.cs";
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Gerando arquivo de mocks!");

            await File.WriteAllTextAsync(fileDir, "");

            Console.WriteLine("Arquivo gerado com sucesso!");
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------");
        }
        private async void GenerateTestsModules()
        {
            string dir = _dir + _projectName + @"Service.Tests\Modules\" + _featureName + @"\" + _moduleName + @"Ctx\";

            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            var fileDir = dir + _moduleName + "ApplicationServiceTests.cs";
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Gerando arquivo de modules!");

            await File.WriteAllTextAsync(fileDir, "");

            Console.WriteLine("Arquivo gerado com sucesso!");
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------");
        }



    }
}
