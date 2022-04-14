function UpdateCost() {

    let donationAmount = $("#DonationAmount").val();
    //For some reason the precision here is not working correctly for all numbers
    let costs = +(donationAmount * 0.029).toFixed(3) + +0.300
    $("#Costs").text(costs.toFixed(2));

    UpdateTotalDonation();
}

function UpdateTotalDonation() {
    let donationAmount = $("#DonationAmount").val();
    let costs = $("#Costs").text();
    let isChecked = $("#CostCoveredChk").is(":checked");
    if (!isChecked) {
        $("#TotalDonation").text(donationAmount);
        return;
    }

    $("#TotalDonation").text(+donationAmount + +costs);
}
