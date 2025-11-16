using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace GameData.Utils
{
	// Token: 0x02000218 RID: 536
	public static class THIZKYExtendedAStar : Il2CppSystem.Object
	{
		// Token: 0x06003DE6 RID: 15846 RVA: 0x0002287D File Offset: 0x00020A7D
		// Note: this type is marked as 'beforefieldinit'.
		static THIZKYExtendedAStar()
		{
			Il2CppClassPointerStore<THIZKYExtendedAStar>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Utils", "THIZKYExtendedAStar");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<THIZKYExtendedAStar>.NativeClassPtr);
			THIZKYExtendedAStar.NativeMethodInfoPtr_AllTilePosWithIn_Public_Static_List_1_Vector2Int_Il2CppReferenceArray_1_Tilemap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<THIZKYExtendedAStar>.NativeClassPtr, 100674631);
		}

		// Token: 0x06003DE7 RID: 15847 RVA: 0x00170940 File Offset: 0x0016EB40
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 138321, RefRangeEnd = 138323, XrefRangeStart = 138291, XrefRangeEnd = 138321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Vector2Int> AllTilePosWithIn([Optional] Il2CppReferenceArray<Tilemap> tilemaps)
		{
			if (tilemaps == null)
			{
				tilemaps = new Il2CppReferenceArray<Tilemap>(0L);
			}
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(tilemaps);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(THIZKYExtendedAStar.NativeMethodInfoPtr_AllTilePosWithIn_Public_Static_List_1_Vector2Int_Il2CppReferenceArray_1_Tilemap_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Vector2Int>>(intPtr3) : null;
		}

		// Token: 0x06003DE8 RID: 15848 RVA: 0x000228B6 File Offset: 0x00020AB6
		public static List<Vector2Int> AllTilePosWithIn(params Tilemap[] tilemaps)
		{
			return THIZKYExtendedAStar.AllTilePosWithIn(new Il2CppReferenceArray<Tilemap>(tilemaps));
		}

		// Token: 0x06003DE9 RID: 15849 RVA: 0x000228C3 File Offset: 0x00020AC3
		public THIZKYExtendedAStar(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04002952 RID: 10578
		private static readonly IntPtr NativeMethodInfoPtr_AllTilePosWithIn_Public_Static_List_1_Vector2Int_Il2CppReferenceArray_1_Tilemap_0;
	}
}
