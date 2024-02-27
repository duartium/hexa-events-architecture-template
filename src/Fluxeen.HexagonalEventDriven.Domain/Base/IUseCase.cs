namespace Fluxeen.HexagonalEventDriven.Domain.Base;

public interface IUseCase<S, T>
{
    ValueTask<T> Execute(S? param);
}