import { Link } from "react-router";

export function NavMenuComponent() {

    return (
        <>
            <div>
                <div>
                    <Link to="/">home</Link>
                    <br />
                    <Link to="/book">book</Link>
                    <br />
                    <Link to="/lineage">lineage</Link>
                    <br />
                </div>
            </div>
        </>
    );

}