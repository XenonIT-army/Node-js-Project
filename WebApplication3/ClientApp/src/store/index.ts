import * as WeatherForecasts from './WeatherForecasts';

export interface ApplicationState {
    weatherForecasts: WeatherForecasts.WeatherForecastsState | undefined;
}

export const reducers = {
    weatherForecasts: WeatherForecasts.reducer
};

export interface AppThunkAction<TAction> {
    (dispatch: (action: TAction) => void, getState: () => ApplicationState): void;
}
