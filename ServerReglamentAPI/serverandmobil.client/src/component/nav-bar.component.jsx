import { Routes, Route } from 'react-router-dom';
import LazyComponent from '../pages/lazy-component';
import BookComponent from '../pages/book-component'
import LineageComponent from '../pages/lineage.component'

export function NavBarComponent() {
    console.log('7771 S s = ' );
 
    return (
        <>
            <div>
                <h3>Nav</h3>
                <div>
                    <Routes>
                        <Route path="/" element={<LazyComponent />} />
                        <Route path="/book" element={<BookComponent />} />
                        <Route path="/lineage" element={<LineageComponent />} />
                    </Routes>
                </div>
            </div>
        </>
    );

}