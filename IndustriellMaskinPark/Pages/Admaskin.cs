using IndustriellMaskinPark.Services;
using IndustriellMaskinPark.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace IndustriellMaskinPark.Pages
{
    public partial class Admaskin
    {
        [Inject]
        public IMaskinService MaskinService { get; set; }
        //[Parameter]
        //public string MaskinId { get; set; } 
        public Maskin Maskin { get; set; } = new Maskin
        { Data = "skjf", Kommando = "ddddd", lagge = Start.på, MHastighet = Hastighet.low, MStatus = Status.Online, Namn = "Robot" };

        protected string Message = string.Empty;
        protected string StatusClass = string.Empty;
        protected bool Saved = false;


        //protected override async Task OnInitializedAsync()
        //{
        //    Maskin = await MaskinService.GetMaskinsDetails(int.Parse(MaskinId));
        //}

        protected async Task HandleValidSubmit()
        {
            //Saved = false;
            //if (Maskin.MaskinId == 0)
            //{
                var addedMaskin = await MaskinService.AddMaskin(Maskin);
                //if (addedMaskin != null)
                //{
                    StatusClass = "alert-success";
                    Message = "Maskinen är sparad";
                    Saved = true;
                //}
                //else
                //{
                //    StatusClass = "alert-danger";
                //    Message = "Maskinen är inte sparad";
                //    Saved = false;
                //}
            //}
            //else
            //{
            //    await MaskinService.UpdateMaskins(Maskin);
            //}
        }

        protected void HandleInvalidSubmit()
        {
            StatusClass = "alert-danger";
            Message = "Validation errors";
        }
    }
}

