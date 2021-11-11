using IndustriellMaskinPark.Components;
using IndustriellMaskinPark.Services;
using IndustriellMaskinPark.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace IndustriellMaskinPark.Pages
{
    public partial class MaskinersInfo
    {
        public IEnumerable<Maskin> Maskiner { get; set; }

        [Inject]
        public IMaskinService MaskinService { get; set; }

        public AddMaskinDialog AddMaskinDialog { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Maskiner = (await MaskinService.GetAllMaskins()).ToList();            
        }
        protected void QuickAddMaskin()
        {
            AddMaskinDialog.Show();
        }
    }
}

