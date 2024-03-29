<?php

namespace DesignPatterns\Criacionais\Prototype;

class Revista implements Prototype
{
    private string $nome;
    private int $edicao;

    public function getNome(): string
    {
        return $this->nome;
    }

    public function setNome(string $nome): void
    {
        $this->nome = $nome;
    }

    public function getEdicao(): int
    {
        return $this->edicao;
    }

    public function setEdicao(int $edicao): void
    {
        $this->edicao = $edicao;
    }

    //Formata o objeto quando impresso.
    public function __toString()
    {
        $saida['nome'] = $this->getNome();
        $saida['edicao'] = $this->getEdicao();

        return json_encode($saida);
    }

    public function clone(): Prototype
    {
        $clone = new Revista();
        $clone->setNome($this->getNome());
        $clone->setEdicao($this->getEdicao());

        return $clone;
    }
}