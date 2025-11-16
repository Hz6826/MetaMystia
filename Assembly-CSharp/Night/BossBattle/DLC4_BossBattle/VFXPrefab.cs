using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x02000085 RID: 133
	[Serializable]
	public sealed class VFXPrefab : ValueType
	{
		// Token: 0x06000D79 RID: 3449 RVA: 0x000CB5C0 File Offset: 0x000C97C0
		// Note: this type is marked as 'beforefieldinit'.
		static VFXPrefab()
		{
			Il2CppClassPointerStore<VFXPrefab>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Night.BossBattle.DLC4_BossBattle", "VFXPrefab");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VFXPrefab>.NativeClassPtr);
			VFXPrefab.NativeFieldInfoPtr_m_VfxType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXPrefab>.NativeClassPtr, "m_VfxType");
			VFXPrefab.NativeFieldInfoPtr_m_PrefabObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXPrefab>.NativeClassPtr, "m_PrefabObject");
			VFXPrefab.NativeFieldInfoPtr_m_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXPrefab>.NativeClassPtr, "m_Duration");
		}

		// Token: 0x06000D7A RID: 3450 RVA: 0x00009054 File Offset: 0x00007254
		public VFXPrefab(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06000D7B RID: 3451 RVA: 0x0000905D File Offset: 0x0000725D
		public VFXPrefab() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VFXPrefab>.NativeClassPtr))
		{
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06000D7C RID: 3452 RVA: 0x000CB62C File Offset: 0x000C982C
		// (set) Token: 0x06000D7D RID: 3453 RVA: 0x0000906F File Offset: 0x0000726F
		public unsafe BossBattleVFX m_VfxType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXPrefab.NativeFieldInfoPtr_m_VfxType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXPrefab.NativeFieldInfoPtr_m_VfxType)) = value;
			}
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06000D7E RID: 3454 RVA: 0x000CB654 File Offset: 0x000C9854
		// (set) Token: 0x06000D7F RID: 3455 RVA: 0x0000908A File Offset: 0x0000728A
		public unsafe GameObject m_PrefabObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXPrefab.NativeFieldInfoPtr_m_PrefabObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXPrefab.NativeFieldInfoPtr_m_PrefabObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06000D80 RID: 3456 RVA: 0x000CB684 File Offset: 0x000C9884
		// (set) Token: 0x06000D81 RID: 3457 RVA: 0x000090A9 File Offset: 0x000072A9
		public unsafe float m_Duration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXPrefab.NativeFieldInfoPtr_m_Duration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXPrefab.NativeFieldInfoPtr_m_Duration)) = value;
			}
		}

		// Token: 0x040008E6 RID: 2278
		private static readonly IntPtr NativeFieldInfoPtr_m_VfxType;

		// Token: 0x040008E7 RID: 2279
		private static readonly IntPtr NativeFieldInfoPtr_m_PrefabObject;

		// Token: 0x040008E8 RID: 2280
		private static readonly IntPtr NativeFieldInfoPtr_m_Duration;
	}
}
