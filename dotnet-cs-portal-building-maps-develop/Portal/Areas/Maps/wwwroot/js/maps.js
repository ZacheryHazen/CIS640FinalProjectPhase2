/*
* Licensed under the MIT License, see LICENSE file for details.
*/

$(document).ready(function () {
    // Convert the search form and building card list into objects
    let buildingData = $('form.building-search-form');
    let buildingCards = $('.building-card');

    buildingData.on("input", (e) => {
        // Get the search query
        let searchQuery = e.target.value.trim();

        // Run this when someone types a character whenever they have already 
        // typed three or more characters into the search bar.
        if (searchQuery && searchQuery.length > 2) {
            // Hide cards which do not contain any words in the search
            for (let i = 0; i < buildingCards.length; i++) {
                let card = $(buildingCards[i]);
                let shouldBeHidden = false;

                shouldBeHidden = shouldHideBuilding(searchQuery,
                    card.data('building-name'),
                    card.data('building-abrev'));

                if (shouldBeHidden && !card.hasClass("hidden")) {
                    card.addClass('hidden');
                }
                else if (!shouldBeHidden && card.hasClass("hidden")) {
                    card.removeClass('hidden');
                }
            }
        }
        else {
            // Make every card visible
            for (let i = 0; i < buildingCards.length; i++) {
                let card = $(buildingCards[i]);

                if (card.hasClass("hidden")) {
                    card.removeClass('hidden');
                }
            }
        }
    })
})

/**
 * Returns false if the contents of the search queries are contained in either 
 * buildingName or buildingAbrev and true otherwise.
 * 
 * @param {string} searchQuery the search queries to look for the rest of the parameters
 * @param {string} buildingName the name of the building
 * @param {string} buildingAbrev the abbreviation of the building name
 * @returns {boolean} false if the building should be hidden, true otherwise.
 */
function shouldHideBuilding(searchQuery, buildingName, buildingAbrev) {
    // Split up the search query into discrete lower case words
    let searchQueries = searchQuery.toLowerCase().split(" ");
    let shouldBeHidden = false;

    buildingName = buildingName.toLowerCase();
    buildingAbrev = buildingAbrev.toLowerCase();

    for (let j = 0; j < searchQueries.length; j++) {
        let word = searchQueries[j];

        if (buildingName.includes(word) ||
            buildingAbrev.includes(word)) {
            // Keep shouldBeHidden as false
        }
        else {
            shouldBeHidden = true;
            break;
        }
    }

    return shouldBeHidden;
}

// If running in a Node environment, make sure to export functions to module
if (typeof module !== 'undefined') {
    module.exports = shouldHideBuilding;
}