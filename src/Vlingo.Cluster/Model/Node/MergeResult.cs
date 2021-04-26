// Copyright © 2012-2021 VLINGO LABS. All rights reserved.
//
// This Source Code Form is subject to the terms of the
// Mozilla Public License, v. 2.0. If a copy of the MPL
// was not distributed with this file, You can obtain
// one at https://mozilla.org/MPL/2.0/.

using System;

namespace Vlingo.Cluster.Model.Node
{
    public class MergeResult : IComparable<MergeResult>
    {
        private readonly bool _joined;
        private readonly Xoom.Wire.Node.Node _node;

        public MergeResult(Xoom.Wire.Node.Node node, bool joined)
        {
            _node = node;
            _joined = joined;
        }

        public bool Joined => _joined;

        public bool Left => !_joined;

        public Xoom.Wire.Node.Node Node => _node;

        public int CompareTo(MergeResult? other) => _node.CompareTo(other?._node);
    }
}