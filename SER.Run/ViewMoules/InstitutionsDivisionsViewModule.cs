using DataBaseManger.DBCommand;
using DataBaseManger.Modules;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SER.Run.ViewMoules
{
    public class InstitutionsDivisionsViewModule : ViewModuleBase
    {
        public InstitutionsDivisionsViewModule(AdminHomeViewModule adminHomeViewModule)
        {
            Divisions = new SelectAllCommand<Division>(App.localDB).SelectAll(true).ConvertAll(new Converter<BaseModel, Division>((x) => (Division)x)).FindAll(x => x.MainDivision.Id == 0);
            EducationalInstitutions = new SelectAllCommand<EducationalInstitution>(App.localDB).SelectAll(true).ConvertAll(new Converter<BaseModel, EducationalInstitution>((x) => (EducationalInstitution)x));

            EducationalAddEdits = new ObservableCollection<EducationalAddEdit>();
            DivisionAddEdits = new ObservableCollection<DivisionAddEdit>();

            foreach (EducationalInstitution item in EducationalInstitutions)   
                EducationalAddEdits.Add(new EducationalAddEdit(adminHomeViewModule, item));

            foreach (Division item in Divisions)    
                DivisionAddEdits.Add(new DivisionAddEdit(adminHomeViewModule, item));

            Divisions = null;
            EducationalInstitutions = null;
        }

        private List<Division> Divisions;

        private List<EducationalInstitution> EducationalInstitutions;
        
        public ObservableCollection<EducationalAddEdit> EducationalAddEdits { get; set; }

        public ObservableCollection<DivisionAddEdit> DivisionAddEdits { get; set; }
    }
}