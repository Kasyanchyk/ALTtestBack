(function(ko) {
    var PersonsViewModel = function(persons) {
        this.persons = ko.observableArray();
        this.nameUse = ["Usual", "Official", "Temp", "Nickname", "Anonymous", "Old", "Maiden"];
        this.gender = ["Male", "Female", "Other", "Unknown"];
        this.addressUse = ["Home", "Work", "Temp", "Old", "State"];
        this.contactPointUse = ["Home", "Work", "Temp"];
        this.contactPointSystem = ["Phone", "Fax", "Email", "Pager", "Url", "Sms", "Other"];


        this.getPersons = async function() {
            var persons = new Persons();

            var data = await persons.getPersons();
            data.map(x => x.genderElement ? x.genderElement.value = this.gender[x.genderElement.value] : null);
            data.map(x => x.address.map(y => y.useElement ? y.useElement.value = this.addressUse[y.useElement.value] : null));
            data.map(x => x.name.map(y => y.useElement ? y.useElement.value = this.nameUse[y.useElement.value] : null));
            data.map(x => x.telecom.map(y => y.useElement ? y.useElement.value = this.contactPointUse[y.useElement.value] : null));
            data.map(x => x.telecom.map(y => y.systemElement ? y.systemElement.value = this.contactPointSystem[y.systemElement.value] : null));
            this.persons(data);
            console.log(data[5]);

        }

    };


    var Persons = function() {
        this.persons = [];
        this.getPersons = async function() {
            return await fetch("http://localhost:52938/api/person", {
                headers: {
                    "Accept": "application/json",
                    "Access-Control-Allow-Origin": "*",
                    "Content-Type": "application/json",
                },
                method: "GET",
            }).then((data) => {
                //console.log(data.json());
                return data.json();
            }).catch((error) => {
                return error;
            });

        }
    };



    ko.applyBindings(new PersonsViewModel(), document.getElementById('personsList'));
})(ko);