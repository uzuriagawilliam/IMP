using IndustriellMaskinPark.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IndustriellMaskinPark.Shared;

namespace IndustriellMaskinPark.Components
{
    public partial class AddMaskinDialog
    {
        public Maskin Maskin { get; set; } = new Maskin
        {  Data = "Dangerous", Kommando = "Protect animals", lagge = Start.på, MHastighet = Hastighet.low, MStatus = Status.Online, Namn = "IRobot" };
        public Start Start { get; set; } = new Start();

        [Inject]
        public IMaskinService MaskinService { get; set; }
        public bool ShowDialog { get; set; }

        public void Show()
        {
            ResetDialog();
            ShowDialog = true;
            StateHasChanged();
        }
        public void Close()
        {
            ShowDialog = false;
            StateHasChanged();
        }
        private void ResetDialog()
        {
            Maskin = new Maskin
            { Data = "skjf", Kommando = "ddddd", lagge = Start.på, MHastighet = Hastighet.low, MStatus = Status.Online, Namn = "Robot" };
        }

        protected async Task HandleValidSubmit()
        {
            var addedMaskin = await MaskinService.AddMaskin(Maskin);
            ShowDialog = false;

            StateHasChanged();
        }
    }
}
