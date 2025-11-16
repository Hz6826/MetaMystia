using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace DayScene.TimelineExtensions
{
	// Token: 0x02000158 RID: 344
	public class DS_NPC_Pos_Reset : PlayableAsset
	{
		// Token: 0x06002757 RID: 10071 RVA: 0x00121968 File Offset: 0x0011FB68
		// Note: this type is marked as 'beforefieldinit'.
		static DS_NPC_Pos_Reset()
		{
			Il2CppClassPointerStore<DS_NPC_Pos_Reset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.TimelineExtensions", "DS_NPC_Pos_Reset");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DS_NPC_Pos_Reset>.NativeClassPtr);
			DS_NPC_Pos_Reset.NativeFieldInfoPtr_characterLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_NPC_Pos_Reset>.NativeClassPtr, "characterLabel");
			DS_NPC_Pos_Reset.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_NPC_Pos_Reset>.NativeClassPtr, 100670252);
			DS_NPC_Pos_Reset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_NPC_Pos_Reset>.NativeClassPtr, 100670253);
		}

		// Token: 0x06002758 RID: 10072 RVA: 0x001219D4 File Offset: 0x0011FBD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90860, XrefRangeEnd = 90873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DS_NPC_Pos_Reset.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002759 RID: 10073 RVA: 0x00121A3C File Offset: 0x0011FC3C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DS_NPC_Pos_Reset() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DS_NPC_Pos_Reset>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DS_NPC_Pos_Reset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600275A RID: 10074 RVA: 0x0001736B File Offset: 0x0001556B
		public DS_NPC_Pos_Reset(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000DB5 RID: 3509
		// (get) Token: 0x0600275B RID: 10075 RVA: 0x00121A78 File Offset: 0x0011FC78
		// (set) Token: 0x0600275C RID: 10076 RVA: 0x00017374 File Offset: 0x00015574
		public unsafe string characterLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_Reset.NativeFieldInfoPtr_characterLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_Reset.NativeFieldInfoPtr_characterLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001A1A RID: 6682
		private static readonly IntPtr NativeFieldInfoPtr_characterLabel;

		// Token: 0x04001A1B RID: 6683
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x04001A1C RID: 6684
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
