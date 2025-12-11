


function BookComponent() {

    getVersion();

    async function getVersion() {
        const response = await fetch('book/getversion');
        console.log("0000 Version", response);
        if (response.ok) {
            console.log("0001 Version", response);
            console.log("0002 Version", response.text());
            const data = response.json();
            console.log("Version", data);
        }
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
