

function LazyComponent() {

    fetch('book/GetStatus').then(
        (response) => {
            if (response.ok == false) {
                console.error("1002 Version");
            }
            console.log('1003  S ss = ', response);
            return response.text();
        }).then((a) => {
            console.log('1099  ход  = ',a);
        });



    return (
        <div>
            <h3>LAZY</h3>

        </div>
    );
}
export default LazyComponent;

