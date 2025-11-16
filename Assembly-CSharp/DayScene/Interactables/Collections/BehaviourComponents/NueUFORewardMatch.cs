using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace DayScene.Interactables.Collections.BehaviourComponents
{
	// Token: 0x02000196 RID: 406
	[Serializable]
	public sealed class NueUFORewardMatch : ValueType
	{
		// Token: 0x06002B83 RID: 11139 RVA: 0x0012F1E8 File Offset: 0x0012D3E8
		// Note: this type is marked as 'beforefieldinit'.
		static NueUFORewardMatch()
		{
			Il2CppClassPointerStore<NueUFORewardMatch>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.Interactables.Collections.BehaviourComponents", "NueUFORewardMatch");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NueUFORewardMatch>.NativeClassPtr);
			NueUFORewardMatch.NativeFieldInfoPtr_needType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NueUFORewardMatch>.NativeClassPtr, "needType");
			NueUFORewardMatch.NativeFieldInfoPtr_RewardType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NueUFORewardMatch>.NativeClassPtr, "RewardType");
			NueUFORewardMatch.NativeFieldInfoPtr_nueRewardPairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NueUFORewardMatch>.NativeClassPtr, "nueRewardPairs");
			NueUFORewardMatch.NativeFieldInfoPtr_nueRewardCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NueUFORewardMatch>.NativeClassPtr, "nueRewardCount");
		}

		// Token: 0x06002B84 RID: 11140 RVA: 0x000194C1 File Offset: 0x000176C1
		public NueUFORewardMatch(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06002B85 RID: 11141 RVA: 0x000194CA File Offset: 0x000176CA
		public NueUFORewardMatch() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NueUFORewardMatch>.NativeClassPtr))
		{
		}

		// Token: 0x17000EDB RID: 3803
		// (get) Token: 0x06002B86 RID: 11142 RVA: 0x0012F268 File Offset: 0x0012D468
		// (set) Token: 0x06002B87 RID: 11143 RVA: 0x000194DC File Offset: 0x000176DC
		public unsafe NueUFONeedType needType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueUFORewardMatch.NativeFieldInfoPtr_needType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueUFORewardMatch.NativeFieldInfoPtr_needType)) = value;
			}
		}

		// Token: 0x17000EDC RID: 3804
		// (get) Token: 0x06002B88 RID: 11144 RVA: 0x0012F290 File Offset: 0x0012D490
		// (set) Token: 0x06002B89 RID: 11145 RVA: 0x000194F7 File Offset: 0x000176F7
		public unsafe NueUFORewardType RewardType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueUFORewardMatch.NativeFieldInfoPtr_RewardType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueUFORewardMatch.NativeFieldInfoPtr_RewardType)) = value;
			}
		}

		// Token: 0x17000EDD RID: 3805
		// (get) Token: 0x06002B8A RID: 11146 RVA: 0x0012F2B8 File Offset: 0x0012D4B8
		// (set) Token: 0x06002B8B RID: 11147 RVA: 0x00019512 File Offset: 0x00017712
		public unsafe Il2CppStructArray<NueRewardPair> nueRewardPairs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueUFORewardMatch.NativeFieldInfoPtr_nueRewardPairs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<NueRewardPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueUFORewardMatch.NativeFieldInfoPtr_nueRewardPairs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EDE RID: 3806
		// (get) Token: 0x06002B8C RID: 11148 RVA: 0x0012F2E8 File Offset: 0x0012D4E8
		// (set) Token: 0x06002B8D RID: 11149 RVA: 0x00019531 File Offset: 0x00017731
		public unsafe int nueRewardCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueUFORewardMatch.NativeFieldInfoPtr_nueRewardCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueUFORewardMatch.NativeFieldInfoPtr_nueRewardCount)) = value;
			}
		}

		// Token: 0x04001CD4 RID: 7380
		private static readonly IntPtr NativeFieldInfoPtr_needType;

		// Token: 0x04001CD5 RID: 7381
		private static readonly IntPtr NativeFieldInfoPtr_RewardType;

		// Token: 0x04001CD6 RID: 7382
		private static readonly IntPtr NativeFieldInfoPtr_nueRewardPairs;

		// Token: 0x04001CD7 RID: 7383
		private static readonly IntPtr NativeFieldInfoPtr_nueRewardCount;
	}
}
