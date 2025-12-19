


function BookComponent() {

    getVersion();

    async function getVersion() {
        await fetch('book/getversion').then(response => {
            console.log("0043 Version", response);
            if (response.ok == false) {
                console.error("0002 Version");
            }
            return response.text();

        }).then(book => {
            console.log("0044 Version", book);
        });
    }

    return (
        <div>
            <h3>Book</h3>
            <div>
            </div>
        </div>
    );
}

export default BookComponent;
