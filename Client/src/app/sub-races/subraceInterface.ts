export interface Race {
    raceID: number;
    raceName: string;
    raceFeatures: string;
    classRaces?: any;
}

export interface SubRace {
    id: number;
    subRaceName: string;
    subraceFeatures: string;
    link: string;
    raceID: number;
    race: Race;
}
