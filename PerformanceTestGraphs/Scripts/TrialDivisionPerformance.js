/// <reference path="jquery-1.4.1-vsdoc.js" />
var trialDivisionValues = [];
var sieveOfEraValues = [];
var baseline = [];
var clicksYet = false;

$(function () {
    var maxLimit = parseInt($("#maxLimit").val());
    var minLimit = parseInt($("#step").val());

    baseline.push([0, 0]);
    baseline.push([maxLimit + minLimit, 100]);
    bindEvents();

    testPerformance();
});

function showTooltip(x, y, contents) {
    if (clicksYet)
        contents += (pointClicked) ? ' hello' : ' bye';

    $('<div id="tooltip">' + contents + '</div>').css({
        position: 'absolute',
        display: 'none',
        top: y + 5,
        left: x + 5,
        border: '1px solid #fdd',
        padding: '2px',
        'background-color': "#FFFFE0",
        opacity: 0.80
    }).appendTo("body").fadeIn(200);
}

function onPointHover(event, pos, item) {
    $("#x").text(pos.x.toFixed(0));
    $("#y").text(pos.y.toFixed(0));

    if (item) {
        if (previousPoint != item.datapoint) {
            previousPoint = item.datapoint;

            $("#tooltip").remove();
            var x = item.datapoint[0].toFixed(0),
                y = item.datapoint[1].toFixed(0);

            showTooltip(item.pageX, item.pageY,
                        x + " primes found in " + y + " ms");
        }
    }
    else {
        $("#tooltip").remove();
        clicksYet = false;
        previousPoint = null;
    }
}

function bindEvents()
{
    $("#testPerformance").click(testPerformance);
    $("#comparisonChart").bind("plothover", onPointHover);
}

function testPerformance() {
    var maxLimit = parseInt($("#maxLimit").val());
    var minLimit = parseInt($("#step").val());

    trialDivision(maxLimit, minLimit);
    sieveOfEratosthenes(maxLimit, minLimit);
}

function trialDivision(maxLimit, minLimit) {
    trialDivisionValues = [];

    for (var i = minLimit; i <= maxLimit; i += minLimit) {
        var constraint = { Limit : i, Increment : 0 };
        PrimeTime.Services.TrialDivision.GetPerformance(constraint, trialDivisionSuccess);
    }
}

function sieveOfEratosthenes(maxLimit, minLimit) {
    sieveOfEraValues = [];

    for (var i = minLimit; i <= maxLimit; i += minLimit) {
        var constraint = { Limit: i, Increment: 0 };
        PrimeTime.Services.SieveOfEratosthenes.GetPerformance(constraint, sieveOfEratosthenesSuccess);
    }
}

function trialDivisionSuccess(result) {
    trialDivisionValues.push([result.NoPrimesFound, result.TimeTaken]);
    plotComparison();
}

function sieveOfEratosthenesSuccess(result) {
    sieveOfEraValues.push([result.NoPrimesFound, result.TimeTaken]);
    plotComparison();
}

function plotTrialDivison() {

    var data = [
            {
                color: "#F08080",
                stack: 0,
                data: trialDivisionValues,
                label: "Trial Division",
                points: { show: true },
                lines: { show: true }
            }
        ];

    $.plot($("#tdChart"), data, {
        grid: {
            hoverable: true,
            clickable: true,
            minBorderMargin: 30
        }
    });
}

function plotSieve() {

    var data = [
            {
                color: "#4682B4",
                stack: 0,
                data: sieveOfEraValues,
                label: "Sieve of Eratosthenes",
                points: { show: true },
                lines: { show: true }
            }
        ];

    $.plot($("#soeChart"), data, {
        grid: {
            hoverable: true,
            clickable: true,
            minBorderMargin: 30
        }        
    });
}

function plotComparison() {

    var data =  [
            {
                data: trialDivisionValues,
                label: "Trial Division",
                points: { show: true },
                lines: { show: true }
            },
            {
                data: sieveOfEraValues,
                label: "Sieve of Eratosthenes",
                points: { show: true },
                lines: { show: true }
            }
        ];

    $.plot($("#comparisonChart"), data, {
            grid: { 
                hoverable: true,
                clickable: true,
                minBorderMargin: 30
            }
        });
}