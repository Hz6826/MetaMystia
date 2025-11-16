using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace DayScene.TimelineExtensions
{
	// Token: 0x02000150 RID: 336
	public class DS_LogicBranch_ChatConfirmation : PlayableAsset
	{
		// Token: 0x060026F5 RID: 9973 RVA: 0x001209A4 File Offset: 0x0011EBA4
		// Note: this type is marked as 'beforefieldinit'.
		static DS_LogicBranch_ChatConfirmation()
		{
			Il2CppClassPointerStore<DS_LogicBranch_ChatConfirmation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.TimelineExtensions", "DS_LogicBranch_ChatConfirmation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DS_LogicBranch_ChatConfirmation>.NativeClassPtr);
			DS_LogicBranch_ChatConfirmation.NativeFieldInfoPtr_acceptAddFrames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_LogicBranch_ChatConfirmation>.NativeClassPtr, "acceptAddFrames");
			DS_LogicBranch_ChatConfirmation.NativeFieldInfoPtr_refuseAddFrames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_LogicBranch_ChatConfirmation>.NativeClassPtr, "refuseAddFrames");
			DS_LogicBranch_ChatConfirmation.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_LogicBranch_ChatConfirmation>.NativeClassPtr, 100670236);
			DS_LogicBranch_ChatConfirmation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_LogicBranch_ChatConfirmation>.NativeClassPtr, 100670237);
		}

		// Token: 0x060026F6 RID: 9974 RVA: 0x00120A24 File Offset: 0x0011EC24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90712, XrefRangeEnd = 90726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DS_LogicBranch_ChatConfirmation.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060026F7 RID: 9975 RVA: 0x00120A8C File Offset: 0x0011EC8C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DS_LogicBranch_ChatConfirmation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DS_LogicBranch_ChatConfirmation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DS_LogicBranch_ChatConfirmation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026F8 RID: 9976 RVA: 0x00016F70 File Offset: 0x00015170
		public DS_LogicBranch_ChatConfirmation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D94 RID: 3476
		// (get) Token: 0x060026F9 RID: 9977 RVA: 0x00120AC8 File Offset: 0x0011ECC8
		// (set) Token: 0x060026FA RID: 9978 RVA: 0x00016F79 File Offset: 0x00015179
		public unsafe int acceptAddFrames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_LogicBranch_ChatConfirmation.NativeFieldInfoPtr_acceptAddFrames);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_LogicBranch_ChatConfirmation.NativeFieldInfoPtr_acceptAddFrames)) = value;
			}
		}

		// Token: 0x17000D95 RID: 3477
		// (get) Token: 0x060026FB RID: 9979 RVA: 0x00120AF0 File Offset: 0x0011ECF0
		// (set) Token: 0x060026FC RID: 9980 RVA: 0x00016F94 File Offset: 0x00015194
		public unsafe int refuseAddFrames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_LogicBranch_ChatConfirmation.NativeFieldInfoPtr_refuseAddFrames);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_LogicBranch_ChatConfirmation.NativeFieldInfoPtr_refuseAddFrames)) = value;
			}
		}

		// Token: 0x040019E9 RID: 6633
		private static readonly IntPtr NativeFieldInfoPtr_acceptAddFrames;

		// Token: 0x040019EA RID: 6634
		private static readonly IntPtr NativeFieldInfoPtr_refuseAddFrames;

		// Token: 0x040019EB RID: 6635
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x040019EC RID: 6636
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
