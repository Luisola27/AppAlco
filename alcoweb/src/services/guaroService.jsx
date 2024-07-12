import { useEffect, useState } from "react";
import { GeneralCall } from "./GeneralCall";

export const GetGuaros = () => {
    const [guaros, setGuaros] = useState([]);

    useEffect(() => {
        const fetchGuaros = async () => {
            try{
                const guarosResponse = await GeneralCall("Guaro");
                setGuaros(guarosResponse.data);
            } catch (error) {
                console.error("Error fetching guaros", error);
            }
        };

        fetchGuaros();
    }, []);

    return guaros;
}