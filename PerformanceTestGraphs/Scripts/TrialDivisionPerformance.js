/// <reference path="jquery-1.4.1-vsdoc.js" />

var trialDivisionValues = [];
var sieveOfEraValues = [];

$(function () {
    bindEvents();
});

function bindEvents()
{
    $("#btnTD").click(trialDivision);
    $("#btnSOE").click(sieveOfErathosthenes);
}

function trialDivision() {
    var constraint = { Limit : 10000, Increment : 1000 };
    PrimeTime.TrialDivision.DoWork(constraint, trialDivisionSuccess);
}

function sieveOfErathosthenes() {
    var constraint = { Limit : 10000, Increment : 1000 };
    PrimeTime.SieveOfErathosthenes.DoWork(constraint, sieveOfErathosthenesSuccess);
}

function trialDivisionSuccess(result) {    
    trialDivisionValues = [];
    updateGraph(result, trialDivisionValues);
}

function sieveOfErathosthenesSuccess(result) {
    sieveOfEraValues = [];
    updateGraph(result, sieveOfEraValues);    
}

function updateGraph(result, container) {
    for (var v in result) {
        container.push([result[v].RangeLimit, result[v].TimeTaken]);
    }

    plotGraph();
}

function plotGraph() {
    $.plot($("#placeholder"), [
            {                
                yaxis: { min: 0, max: 50,  },
                data: trialDivisionValues,
                label: "Trial Division",
                lines: { show: true },
                points: { show: true }
            },
            {
                data: sieveOfEraValues,
                label: "Sieve of Erathosthenes",
                lines: { show: true },
                points: { show: true }
            },
        ]);
}