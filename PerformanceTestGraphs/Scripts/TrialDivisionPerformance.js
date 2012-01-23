/// <reference path="jquery-1.4.1-vsdoc.js" />

var minLimit = 10000;
var maxLimit = 100000;
var increment = 10000;
var trialDivisionValues = [];
var sieveOfEraValues = [];
var baseline = [];

$(function () {
    baseline.push([minLimit - increment, 0]);
    baseline.push([maxLimit + increment, 100]);
    bindEvents();
});

function bindEvents()
{
    $("#btnTD").click(trialDivision);
    $("#btnSOE").click(sieveOfErathosthenes);
}

function trialDivision() {
    trialDivisionValues = [];

    for (var i = minLimit; i <= maxLimit; i += increment) {
        var constraint = { Limit : i, Increment : 0 };    
        PrimeTime.TrialDivision.GetPerformance(constraint, trialDivisionSuccess);
    }
}

function sieveOfErathosthenes() {
    sieveOfEraValues = [];

    for (var i = minLimit; i <= maxLimit; i += increment) {
        var constraint = { Limit: i, Increment: 0 };
        PrimeTime.SieveOfErathosthenes.GetPerformance(constraint, sieveOfErathosthenesSuccess);
    }
}

function trialDivisionSuccess(result) {
    trialDivisionValues.push([result.RangeLimit, result.TimeTaken]);
    plotGraph();
}

function sieveOfErathosthenesSuccess(result) {
    sieveOfEraValues.push([result.RangeLimit, result.TimeTaken]);
    plotGraph();
}

function plotGraph() {
    $.plot($("#placeholder"), [
            {
                data: baseline,
                lines: { show: false },
                points: { show: false }
            },
            {                
                stack : 0,
                data: trialDivisionValues,
                label: "Trial Division",
                bars: { show: true, barWidth: 5000 }
            },
            {
                stack: 0,
                data: sieveOfEraValues,
                label: "Sieve of Erathosthenes",
                bars: { show: true, barWidth: 5000 }
            }
        ]);
}