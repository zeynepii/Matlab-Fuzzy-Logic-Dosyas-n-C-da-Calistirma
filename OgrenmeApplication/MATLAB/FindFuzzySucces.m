function [appValue] = FindFuzzySucces(ilgi,seviye,sonuc)
%UNT�TLED2 Summary of this function goes here
%   Detailed explanation goes here
a=readfis('app');

appValue=evalfis([ilgi;seviye;sonuc],a);

end

