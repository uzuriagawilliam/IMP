using IndustriellMaskinPark.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IndustriellMaskinPark.Shared;

namespace IndustriellMaskinPark.Pages
{
    public partial class Kommando
    {
        [Parameter]
        public int MaskinId { get; set; }

        public Maskin Maskin { get; set; } = new Maskin();
       
        public IEnumerable<Maskin> Maskiner { get; set; }

        [Inject]
        public IMaskinService MaskinService { get; set; }

        private int actualNumber { get; set; } = 1;
        //private string TextValue { get; set; } = "New kommando";

        protected async override Task OnInitializedAsync()
        {            
            Maskin = await MaskinService.GetMaskinsDetails(MaskinId);
        } 
    }
}
