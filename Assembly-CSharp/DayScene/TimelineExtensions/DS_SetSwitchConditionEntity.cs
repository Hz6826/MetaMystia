using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace DayScene.TimelineExtensions
{
	// Token: 0x0200015C RID: 348
	public class DS_SetSwitchConditionEntity : PlayableAsset
	{
		// Token: 0x06002789 RID: 10121 RVA: 0x0012217C File Offset: 0x0012037C
		// Note: this type is marked as 'beforefieldinit'.
		static DS_SetSwitchConditionEntity()
		{
			Il2CppClassPointerStore<DS_SetSwitchConditionEntity>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.TimelineExtensions", "DS_SetSwitchConditionEntity");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DS_SetSwitchConditionEntity>.NativeClassPtr);
			DS_SetSwitchConditionEntity.NativeFieldInfoPtr_visualEntityLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_SetSwitchConditionEntity>.NativeClassPtr, "visualEntityLabel");
			DS_SetSwitchConditionEntity.NativeFieldInfoPtr_on = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_SetSwitchConditionEntity>.NativeClassPtr, "on");
			DS_SetSwitchConditionEntity.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_SetSwitchConditionEntity>.NativeClassPtr, 100670260);
			DS_SetSwitchConditionEntity.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_SetSwitchConditionEntity>.NativeClassPtr, 100670261);
		}

		// Token: 0x0600278A RID: 10122 RVA: 0x001221FC File Offset: 0x001203FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90930, XrefRangeEnd = 90945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DS_SetSwitchConditionEntity.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600278B RID: 10123 RVA: 0x00122264 File Offset: 0x00120464
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DS_SetSwitchConditionEntity() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DS_SetSwitchConditionEntity>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DS_SetSwitchConditionEntity.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600278C RID: 10124 RVA: 0x0001757E File Offset: 0x0001577E
		public DS_SetSwitchConditionEntity(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000DC6 RID: 3526
		// (get) Token: 0x0600278D RID: 10125 RVA: 0x001222A0 File Offset: 0x001204A0
		// (set) Token: 0x0600278E RID: 10126 RVA: 0x00017587 File Offset: 0x00015787
		public unsafe string visualEntityLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_SetSwitchConditionEntity.NativeFieldInfoPtr_visualEntityLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_SetSwitchConditionEntity.NativeFieldInfoPtr_visualEntityLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000DC7 RID: 3527
		// (get) Token: 0x0600278F RID: 10127 RVA: 0x001222C8 File Offset: 0x001204C8
		// (set) Token: 0x06002790 RID: 10128 RVA: 0x000175A6 File Offset: 0x000157A6
		public unsafe bool on
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_SetSwitchConditionEntity.NativeFieldInfoPtr_on);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_SetSwitchConditionEntity.NativeFieldInfoPtr_on)) = value;
			}
		}

		// Token: 0x04001A33 RID: 6707
		private static readonly IntPtr NativeFieldInfoPtr_visualEntityLabel;

		// Token: 0x04001A34 RID: 6708
		private static readonly IntPtr NativeFieldInfoPtr_on;

		// Token: 0x04001A35 RID: 6709
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x04001A36 RID: 6710
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
