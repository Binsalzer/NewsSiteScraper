import React, {useState, useEffect} from 'react';
import 'bootstrap/dist/css/bootstrap.min.css';
import './Home.css';
import axios from 'axios'

const Home = () => {

    const [headlines, setHeadlines] = useState([]);

    useEffect(() => {
        const loadHeadlines = async () => {
            const { data } = await axios.get('/api/headlines/getheadlines')
            setHeadlines(data)
        }

        loadHeadlines()
    }, [])
    
    return (
        <div className='container'>
            {!!headlines && headlines.map(h =>
                <div>
                    <a href={h.articleUrl}><h1>{h.title}</h1></a>
                    <br></br>
                    <img src={h.imageUrl}></img>
                    <br></br>
                    <h3>{h.blurbText}</h3>
                    <br></br>
                    <h4>{h.commentCount }</h4>
            </div>)}
        </div>
    );
};

export default Home;